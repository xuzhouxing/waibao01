using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waibao01
{
    public class Group
    {
        public Group()
        {
            this.Nodes = new List<Group>();
            this.ParentId = 0;//主节点的父id默认为0
        }

        public List<Group> Nodes { get; set; }
        public int ID { get; set; }//id
        public int ParentId { get; set; }//parentID
        public string GroupName { get; set; }
    }
}
