﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public  class CreditCard:IEntity
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardCvc { get; set; }
        public string CardExpiration { get; set; }
    }
}
