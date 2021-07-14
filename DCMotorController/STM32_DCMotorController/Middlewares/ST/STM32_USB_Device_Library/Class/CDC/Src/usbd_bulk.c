/**
  ******************************************************************************
  * @file    usbd_bulk.c
  * @author  HIENCLUBVN Fix Using Bulk Transfer./
  * @version V1.0
  * @date    25/05/2015
  * @brief   This file provides the BULK core functions.
  *
  * @verbatim
  *      
  *          ===================================================================      
  *                                BULK Class  Description
  *          =================================================================== 
  *             - CODER : HIENCLUBVN. 
  *      
  * @note     In HS mode and when the DMA is used, all variables and data structures
  *           dealing with the DMA during the transaction process should be 32-bit aligned.
  *           
  *      
  *  @endverbatim
  *
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; COPYRIGHT 2015 STMicroelectronics</center></h2>
  *
  * Licensed under MCD-ST Liberty SW License Agreement V2, (the "License");
  * You may not use this file except in compliance with the License.
  * You may obtain a copy of the License at:
  *
  *        http://www.st.com/software_license_agreement_liberty_v2
  *
  * Unless required by applicable law or agreed to in writing, software 
  * distributed under the License is distributed on an "AS IS" BASIS, 
  * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  * See the License for the specific language governing permissions and
  * limitations under the License.
  *
  ******************************************************************************
  */ 

/* Includes ------------------------------------------------------------------*/
#include "usbd_bulk.h"
#include "usbd_desc.h"
#include "usbd_ctlreq.h"

#include "main.h"

/** @addtogroup STM32_USB_DEVICE_LIBRARY
  * @{
  */


/** @defgroup USBD_BULK 
  * @brief usbd core module
  * @{
  */ 

/** @defgroup USBD_BULK_Private_TypesDefinitions
  * @{
  */ 
/**
  * @}
  */ 


/** @defgroup USBD_BULK_Private_Defines
  * @{
  */ 

/**
  * @}
  */ 


/** @defgroup USBD_BULK_Private_Macros
  * @{
  */ 
/**
  * @}
  */ 
/** @defgroup USBD_BULK_Private_FunctionPrototypes
  * @{
  */


static uint8_t  USBD_BULK_Init (USBD_HandleTypeDef *pdev, 
                               uint8_t cfgidx);

static uint8_t  USBD_BULK_DeInit (USBD_HandleTypeDef *pdev, 
                                 uint8_t cfgidx);

static uint8_t  USBD_BULK_Setup (USBD_HandleTypeDef *pdev, 
                                USBD_SetupReqTypedef *req);

static uint8_t  *USBD_BULK_GetCfgDesc (uint16_t *length);

static uint8_t  USBD_BULK_DataIn (USBD_HandleTypeDef *pdev, uint8_t epnum);

static uint8_t  USBD_BULK_DataOut (USBD_HandleTypeDef *pdev, uint8_t epnum);

/**
  * @}
  */ 

/** @defgroup USBD_BULK_Private_Variables
  * @{
  */ 

USBD_ClassTypeDef  USBD_BULK = 
{
  USBD_BULK_Init,
  USBD_BULK_DeInit,
  USBD_BULK_Setup,
  NULL, /*EP0_TxSent*/  
  NULL, /*EP0_RxReady*/ /* STATUS STAGE IN */
  USBD_BULK_DataIn, /*DataIn*/
  USBD_BULK_DataOut,
  NULL, /*SOF */
  NULL,
  NULL,      
  USBD_BULK_GetCfgDesc,
  USBD_BULK_GetCfgDesc, 
  USBD_BULK_GetCfgDesc,
	NULL, //  USBD_BULK_GetDeviceQualifierDesc,
};

/* USB BULK device Configuration Descriptor */
__ALIGN_BEGIN static uint8_t USBD_BULK_CfgDesc[32] __ALIGN_END =
{
  0x09, /* bLength: Configuration Descriptor size */
  USB_DESC_TYPE_CONFIGURATION, /* bDescriptorType: Configuration */
  32,
  /* wTotalLength: Bytes returned */
  0x00,
  0x01,         /*bNumInterfaces: 1 interface*/
  0x01,         /*bConfigurationValue: Configuration value*/
  0x00,         /*iConfiguration: Index of string descriptor describing
  the configuration*/
  0xC0,         /*bmAttributes: bus powered */
  0x32,         /*MaxPower 100 mA: this current is used for detecting Vbus*/
  
  /************** Descriptor of CUSTOM HID interface ****************/
  /* 09 */
  0x09,         /*bLength: Interface Descriptor size*/
  USB_DESC_TYPE_INTERFACE,/*bDescriptorType: Interface descriptor type*/
  0x00,         /*bInterfaceNumber: Number of Interface*/
  0x00,         /*bAlternateSetting: Alternate setting*/
  0x02,         /*bNumEndpoints*/
  0xFF,         /*bInterfaceClass: Vendor-specific*/
  0x00,         /*bInterfaceSubClass : 1=BOOT, 0=no boot*/
  0x00,         /*nInterfaceProtocol : 0=none, 1=keyboard, 2=mouse*/
  0,            /*iInterface: Index of string descriptor*/
  /******************** Descriptor of Custom HID endpoints ********************/
  /* xx */
  0x07,          /*bLength: Endpoint Descriptor size*/
  USB_DESC_TYPE_ENDPOINT, /*bDescriptorType:*/
  BULK_EPIN_ADDR,     /*bEndpointAddress: Endpoint Address (IN) 0x81*/
  0x02,          /*bmAttributes: Bulk endpoint*/
  BULK_EPIN_SIZE, /*wMaxPacketSize: 64 Byte max */
  0x00,
  0x00,          /*bInterval: Polling Interval (20 ms)*/
  /* xx */
  
  0x07,	         /* bLength: Endpoint Descriptor size */
  USB_DESC_TYPE_ENDPOINT,	/* bDescriptorType: */
  BULK_EPOUT_ADDR,  /*bEndpointAddress: Endpoint Address (OUT)*/
  0x02,	/* bmAttributes: Bulk endpoint */
  BULK_EPOUT_SIZE,	/* wMaxPacketSize: 64 Bytes max  */
  0x00,
  0x00,	/* bInterval:  (00 ms) */
  /* 32 */
} ;

/**
  * @}
  */ 

/** @defgroup USBD_BULK_Private_Functions
  * @{
  */ 

/**
  * @brief  USBD_BULK_Init
  *         Initialize the BULK interface
  * @param  pdev: device instance
  * @param  cfgidx: Configuration index
  * @retval status
  */
extern uint8_t rxUsbBuffer[64];
extern char txUsbBuffer[64];
extern __IO uint8_t rxUsbBufferCOPY[64];
static uint8_t  USBD_BULK_Init (USBD_HandleTypeDef *pdev, 
                               uint8_t cfgidx)
{

  /* Open EP IN */
  USBD_LL_OpenEP(pdev,
                 BULK_EPIN_ADDR,
                 USBD_EP_TYPE_BULK,	// fix
                 BULK_EPIN_SIZE);  
  
  /* Open EP OUT */
  USBD_LL_OpenEP(pdev,
                 BULK_EPOUT_ADDR,
                 USBD_EP_TYPE_BULK,
                 BULK_EPOUT_SIZE);
  // Ham nhan du lieu tu PC gui xuong./ 
	USBD_LL_PrepareReceive(pdev, BULK_EPOUT_ADDR ,rxUsbBuffer,64);
//  return ret;
	return USBD_OK;
}

/**
  * @brief  USBD_BULK_Init
  *         DeInitialize the BULK layer
  * @param  pdev: device instance
  * @param  cfgidx: Configuration index
  * @retval status
  */
static uint8_t  USBD_BULK_DeInit (USBD_HandleTypeDef *pdev, 
                                 uint8_t cfgidx)
{
  /* Close BULK EP IN */
  USBD_LL_CloseEP(pdev,
                  BULK_EPIN_ADDR);
  
  /* Close BULK EP OUT */
  USBD_LL_CloseEP(pdev,
                  BULK_EPOUT_ADDR);
    return USBD_OK;
}

/**
  * @brief  USBD_BULK_Setup
  *         Handle the BULK specific requests
  * @param  pdev: instance
  * @param  req: usb requests
  * @retval status
  */
__ALIGN_BEGIN static uint32_t  USBD_HID_AltSet  __ALIGN_END = 0; // FIx
static uint8_t  USBD_BULK_Setup (USBD_HandleTypeDef *pdev, 
                                USBD_SetupReqTypedef *req)
{
  switch (req->bmRequest & USB_REQ_TYPE_MASK)
  {
  case USB_REQ_TYPE_CLASS :  
    switch (req->bRequest)
    {
//      default:	// fix
//      USBD_CtlError (pdev, req); // fix
//      return USBD_FAIL;  // fix
    }
    break;
    
  case USB_REQ_TYPE_STANDARD:
    switch (req->bRequest)
    {
    case USB_REQ_GET_DESCRIPTOR: 
      break;
      
    case USB_REQ_GET_INTERFACE :
      USBD_CtlSendData (pdev,
                        (uint8_t *)&USBD_HID_AltSet,
                        1);
      break;
      
    case USB_REQ_SET_INTERFACE :
      USBD_HID_AltSet = (uint8_t)(req->wValue);
      break;
    }
  }
  return USBD_OK;
}

/**
  * @brief  USBD_BULK_SendReport 
  *         Send BULK Report
  * @param  pdev: device instance
  * @param  buff: pointer to report
  * @retval status
  */
uint8_t USBD_BULK_SendData     (USBD_HandleTypeDef  *pdev, 
                                 uint8_t *report,
                                 uint16_t len)
{
  
  if (pdev->dev_state == USBD_STATE_CONFIGURED )
  {
		USBD_LL_Transmit (pdev, 
                        BULK_EPIN_ADDR,                                      
                        report,
                        len);
		return USBD_OK;
  }
  return USBD_FAIL;	// Fix
}

/**
  * @brief  USBD_BULK_GetCfgDesc 
  *         return configuration descriptor
  * @param  speed : current device speed
  * @param  length : pointer data length
  * @retval pointer to descriptor buffer
  */
static uint8_t  *USBD_BULK_GetCfgDesc (uint16_t *length)
{
  *length = sizeof (USBD_BULK_CfgDesc);
  return USBD_BULK_CfgDesc;
}

/**
  * @brief  USBD_BULK_DataIn
  *         handle data IN Stage
  * @param  pdev: device instance
  * @param  epnum: endpoint index
  * @retval status
  */
static uint8_t  USBD_BULK_DataIn (USBD_HandleTypeDef *pdev, 
                              uint8_t epnum)
{
  HAL_GPIO_TogglePin(GPIOD,GPIO_PIN_15);
	/* Ensure that the FIFO is empty before a new transfer, this condition could 
  be caused by  a new transfer before the end of the previous transfer */
 // ((USBD_BULK_HandleTypeDef *)pdev->pClassData)->state = BULK_IDLE;
	USBD_LL_FlushEP(pdev,BULK_EPIN_ADDR);
	  return USBD_OK;
}

/**
  * @brief  USBD_BULK_DataOut
  *         handle data OUT Stage
  * @param  pdev: device instance
  * @param  epnum: endpoint index
  * @retval status
  */
// Ham nay thuc hien sau khi da Nhan duoc All Data tu PC gui den./
extern Status cComStatus;
static uint8_t  USBD_BULK_DataOut (USBD_HandleTypeDef *pdev, 
                              uint8_t epnum)
{
	// Ham nhan giu Lieu .../
	USBD_LL_PrepareReceive(pdev, BULK_EPOUT_ADDR ,rxUsbBuffer,64);
	cComStatus.ready = 1;
	
	// Nhan dc thi gui luon.
	//len = sprintf(txUsbBuffer,"%ld,%ld,%ld\r\n",(long)setpoint,(long)speed,(long)pwm);
	USBD_BULK_SendData(pdev,(uint8_t*)txUsbBuffer,64);//txUsbBuffer,64); // Nhan dc bao nhieu thi gui het./
	//USBD_BULK_SendData(pdev,rxUsbBuffer,64);//txUsbBuffer,64);
	
	//HAL_GPIO_TogglePin(GPIOD,GPIO_PIN_14);
	//
  return USBD_OK;
}

/**
  * @brief  USBD_BULK_EP0_RxReady
  *         Handles control request data.
  * @param  pdev: device instance
  * @retval status
  */


/**
* @brief  DeviceQualifierDescriptor 
*         return Device Qualifier descriptor
* @param  length : pointer data length
* @retval pointer to descriptor buffer
*/

/**
  * @}
  */ 


/**
  * @}
  */ 

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
