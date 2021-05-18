﻿using System.Runtime.Serialization;
using System.ComponentModel;
using DinerBusinessLogic.Attributes;

namespace DinerBusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel
    {
        [DataMember]
        [Column(title: "Номер", width: 100, visible: false)]
        public int? Id { get; set; }
        [DataMember]
        [Column(title: "ФИО", width: 150)]
        public string ClientFIO { get; set; }
        [DataMember]
        [Column(title: "Логин", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Email { get; set; }
        [DataMember]
        [Column(title: "Пароль", width: 150)]
        public string Password { get; set; }
    }
}
