using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Linq;
using KanbanBoard.Server;
using FireSharp;

namespace KanbanBoard.Forms
{
    class Firebase
    {
        public static string AuthSecret { get; }

        public static string BasePath { get; }

        public static IFirebaseClient client { get; }

        static Firebase()
        {
            AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt";
            BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/";
            client = new FirebaseClient(new FirebaseConfig() { AuthSecret = AuthSecret, BasePath = BasePath });

        }

        public static void Save(Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> dataDictionary)
        {
            foreach (var project in dataDictionary)
            {
                client.Set($"Projects/{project.Key}/BoardInfo", project.Value);
            }
        }



    }
}
