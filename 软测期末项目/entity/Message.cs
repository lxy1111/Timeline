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
        private User user;

        public Message(string content, string ImageURL,string posttime,User user)
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

        public User getUser()
        {
            return user;
        }

        public void setUser(User user)
        {
            this.user = user;
        }
        
        
    }
}
