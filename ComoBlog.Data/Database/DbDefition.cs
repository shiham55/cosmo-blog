using System;
using System.Collections.Generic;
using System.Text;

namespace ComoBlog.Data.Database
{
    //https://andrewlock.net/running-async-tasks-on-app-startup-in-asp-net-core-3/

    //https://docs.microsoft.com/en-us/dotnet/api/microsoft.azure.documents.client.documentclient.createdatabaseifnotexistsasync?view=azure-dotnet
    public class DbDefition
    {
        private static string accountURI = "Your URI";
        private static string accountKey = "Your Key";
        public static string DatabaseId { get; private set; } = "ToDoList";
        public static string ToDoItemsId { get; private set; } = "ToDoItems";

       
    }
}
