using Cassandra;
using System;
public class DataFiller{
    static DataFiller singleton;
    static Cluster cluster;
    static ISession session;
    static public DataFiller Singleton(){
        if (singleton == null)
            singleton = new DataFiller();
        return singleton;
    }
    DataFiller(){
        cluster = Cluster.Builder().AddContactPoints("localhost").Build();
        // Connect to the nodes using a keyspace
        session = cluster.Connect("temperaturedatabase");
    }
    public static void FillDataBase(Temperature temp){
        PreparedStatement query = session.Prepare("INSERT INTO Temperature (IdTemperature,temperaturedata, time) VALUES (?,?,?)");
        BatchStatement batch = new BatchStatement().Add(query.Bind(Temperature.Id,temp.Temp, DateTimeOffset.Now));
        // Execute the batch
        session.Execute(batch);
    }
}