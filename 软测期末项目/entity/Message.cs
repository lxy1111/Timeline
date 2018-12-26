using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeline.Interface;

namespace Timeline.entity
{
   
    public class Message
    {
        private string content;
        private string ImageURL;
        private string posttime;
        private observer user;

        public Message(string content, string ImageURL,string posttime,observer user)
        {
            this.content = content;
            this.ImageURL = ImageURL;
            this.posttime = posttime;
            this.user = user;
        }

        public string getPosttime()
        {
            return this.posttime;
        }

        public void setPosttime(string posttime)
        {
            this.posttime = posttime;
        }

        public string getContent()
        {
            return this.content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public string getImageURL()
        {
            return this.ImageURL;
        }

        public void setImageURL(string ImageURL)
        {
            this.ImageURL = ImageURL;
        }

        public observer getUser()
        {
            return user;
        }

        public void setUser(observer user)
        {
            this.user = user;
        }
        
        
    }
}
