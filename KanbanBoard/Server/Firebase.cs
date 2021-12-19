using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}
