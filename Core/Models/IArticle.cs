using System;

namespace Core.Models
{
    public interface IArticle
    {
        int ID {get; set;}
        String Name {get; set;}
        String Description {get; set;}
        DateTime CreatedAt {get; set;}

    }
    
}
