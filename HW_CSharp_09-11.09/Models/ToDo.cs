using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace HW_CSharp_09_11._09.Models
{
    [DataContract]
    public class ToDo
    {
        [DataMember]
        public int userId;

        [DataMember]
        public int id;

        [DataMember]
        public string title;

        [DataMember]
        public bool completed;
    }

    public class TodoListModel
    {
        public List<ToDo> todos { get; set; }
    }
}