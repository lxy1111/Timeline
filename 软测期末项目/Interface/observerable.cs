using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.Interface;

namespace Timeline.Interface
{
    interface observerable
    {
        bool registerobserver(observer observer);
        bool removeobserver(observer observer);
        bool notifyobserver();

    }
}
