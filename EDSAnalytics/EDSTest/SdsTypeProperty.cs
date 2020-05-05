﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EDSAnalytics
{
    class SdsTypeProperty
    {
        public string Id{
            get;
            set;
        }

        public string Name{
            get;
            set;
        }

        public string Description{
            get;
            set;
        }

        public SdsType SdsType{
            get;
            set;
        }

        public bool IsKey{
            get;
            set;
        }
    }
}

