using System;
using RonieProjecsHomeTest.Users;


namespace RonieProjecsHomeTest.SaveFile
{
    public interface Isave
    {
        void  Save(String path, List<User> users);
        
    }
}
