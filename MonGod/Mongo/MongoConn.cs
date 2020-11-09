using System;
using MongoDB.Driver;
using MonGod.Colorama;

namespace MonGod.Mongo
{
    public class MongoConn
    {
        private MongoClient Client;

        public MongoConn()
        {
            Coloro coloro = new Coloro(true);
            
            try
            {
                Client = new MongoClient(
                    "mongodb://localhost:27017/"
                );
                
                coloro.WriteLine("[Conn Success]", ConsoleColor.Green);
            }
            catch (Exception _)
            {
                coloro.WriteLine("[Conn Failed]", ConsoleColor.Red);
            }
        }
    }
}