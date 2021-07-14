/**
  ******************************************************************************
  * @file    usbd_bulk.h
  * @author  HIENCLUBVN
  * @version V1.0
  * @date    27/05/2015
  * @brief   header file for the usbd_bulk.c file.
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
 
/* Define to prevent recursive inclusion -------------------------------------*/ 
#ifndef __USB_BULK_H
#define __USB_BULK_H

#ifdef __cplusplus
 extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include  "usbd_ioreq.h"

/** @addtogroup STM32_USB_DEVICE_LIBRARY
  * @{
  */
  
/** @defgroup USBD_BULK
  * @brief This file is the Header file for USBD_customhid.c
  * @{
  */ 


/** @defgroup USBD_BULK_Exported_Defines
  * @{
  */ 
#define BULK_EPIN_ADDR                 0x81
#define BULK_EPIN_SIZE                 0x40

#define BULK_EPOUT_ADDR                0x01
#define BULK_EPOUT_SIZE                0x40

/**
  * @}
  */ 

/** @defgroup USBD_CORE_Exported_Variables
  * @{
  */ 

extern USBD_ClassTypeDef  USBD_BULK;
//#define USBD_BULK_CLASS    &USBD_BULK
/**
  * @}
  */ 

/** @defgroup USB_CORE_Exported_Functions
  * @{
  */ 
uint8_t USBD_BULK_SendData (USBD_HandleTypeDef *pdev, 
                                 uint8_t *report,
                                 uint16_t len);

/**
  * @}
  */ 

#ifdef __cplusplus
}
#endif

#endif  /* __USB_CUSTOMHID_H */
/**
  * @}
  */ 

/**
  * @}
  */ 
  
/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
