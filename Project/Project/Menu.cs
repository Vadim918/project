using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Project
{
    [DataContract]
    class Menu
    {
        [DataMember]
        List<string> pizza = new List<string>()
        {
           "Гавайская",
            "Грибная ",
            "Баварская",
            "Филадельфия",
            "Мясная",
            "Четыре сыра",
            "Мексиканская"
        };        
    }
}

