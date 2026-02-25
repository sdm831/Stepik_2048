using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace start
{
    public class UserManager
    {
        public static string Path = "results.json";

        public static List<User> GetAll()
        {
            if (FileProvider.Exists(Path))
            {
                var jsonData = FileProvider.GetValue(Path);

                return JsonConvert.DeserializeObject<List<User>>(jsonData);
            }

            return new List<User>();
        }

        public static void Add(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);

            var jsonData = JsonConvert.SerializeObject(users);
            FileProvider.Replace(Path, jsonData);
        }
    }
}
