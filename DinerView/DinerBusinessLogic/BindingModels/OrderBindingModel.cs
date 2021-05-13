﻿using System;
using DinerBusinessLogic.Enums;
using System.Runtime.Serialization;

namespace DinerBusinessLogic.BindingModels
{
    //заказ
    [DataContract]
    public class OrderBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public int? ClientId { get; set; }
        [DataMember]
        public int SnackId { get; set; }
        [DataMember]
        public int? ImplementerId { get; set; }
        [DataMember]
        public bool? FreeOrders { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
        [DataMember]
        public OrderStatus Status { get; set; }
        [DataMember]
        public DateTime DateCreate { get; set; }
        [DataMember]
        public DateTime? DateImplement { get; set; }
        [DataMember]
        public DateTime? DateFrom { get; set; }
        [DataMember]
        public DateTime? DateTo { get; set; }
    }
}
