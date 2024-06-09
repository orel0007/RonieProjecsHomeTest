using System;
using RonieProjecsHomeTest.Users;


namespace RonieProjecsHomeTest.SaveFile
{
    interface Isave
    {
        void Save(string path, List<User> users);
    }
}
