using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.entity;

namespace Timeline.Interface
{
    public interface MessageDao
    {
        List<Message> getAllNews();
        bool publishMessage(Message message);
    }
}
