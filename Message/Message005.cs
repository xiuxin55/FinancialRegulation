﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Message
{
    /// <summary>
    /// 不明账款缴存响应 担保到银行
    /// </summary>
    [XmlRoot("Message005")]
    public class Message005:BaseMessageResponse
    {
        //public string BusinessCode { get; set; }      //交易代码
        //public string BusinessTime { get; set; }      //交易时间
        //public string SerialNo { get; set; }          //交易流水号
        //public string PactNo { get; set; }            //协议编号
        public string CorpCode { get; set; }          //企业名称
        public decimal Money { get; set; }            //存款金额
        public string NatureOfFunding { get; set; }   //资金性质
        public string FromBbank { get; set; }         //存款银行
        public decimal Balances { get; set; }         //账户余额
        public string CRCCode { get; set; }           //CRC校验码
        //public string ExceptionCode { get; set; }     //1总金额超出预售款2crc校验错误
        //public string ExceptionMessage { get; set; }  //异常信息

        public override bool MeaasgeOperate()
        {
            throw new NotImplementedException();
        }
    }
}
