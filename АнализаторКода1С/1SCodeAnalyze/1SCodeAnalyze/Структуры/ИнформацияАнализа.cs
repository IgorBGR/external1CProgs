﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1SCodeAnalyze
{
    class ИнформацияАнализа
    {
        public String ОписаниеПроблемы;
        public String ПроблемныйКод;
        public int Смещение;

		public ИнформацияАнализа(int index, String Описание, String Проблема){
			Смещение = index;
			ОписаниеПроблемы = Описание;
			ПроблемныйКод = Проблема;
		}
    }
}
