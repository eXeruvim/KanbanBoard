using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Collections.Generic;

namespace KanbanBoard.Server
{
    class Firebase
    {
        public static string AuthSecret { get; }
        public static string BasePath { get; }
        public static IFirebaseClient сlient { get; }

        static Firebase()
        {
            AuthSecret = "EalE4Ra04uGQuLuA0zEhemNqzL2q0kAxzhJxHZrt";
            BasePath = "https://kanbanboard-c892f-default-rtdb.europe-west1.firebasedatabase.app/";
            сlient = new FirebaseClient(new FirebaseConfig() { AuthSecret = AuthSecret, BasePath = BasePath });
        }

        public static void Save(Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>> dataDictionary)
        {
            foreach (var project in dataDictionary)
            {
                сlient.Set($"Projects/{project.Key}/BoardInfo", project.Value);
            }
        }
    }
}
