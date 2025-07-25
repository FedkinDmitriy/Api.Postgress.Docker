﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Enums
{
    /// <summary>
    /// Перечисление возможных статусов заказа.
    /// 0 - Не_обработан, 1 - Отменен, 2 - Выполнен
    /// </summary>
    public enum OrderStatus
    {
        Не_обработан = 0,

        Отменен = 1,

        Выполнен = 2
    }
}
