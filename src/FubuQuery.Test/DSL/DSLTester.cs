namespace FubuQuery.Test.DSL
{
    public class DSLTester
    {
        // First stab at what the DSL might look like...


//public class BinCountDTO
//{
//    public string BinName { get; set; }
//    public int ItemCount { get; set; }
//}

//public class ConsoleDTO
//{
//    public int UnqueuedItemsCount { get; set; }
//    public int QueuedItemsCount { get; set; }
//    public BinCountDTO[] ByItemType { get; set; }
//    public BinCountDTO[] Queues { get; set; }
//    public BinCountDTO[] Tags { get; set; }
//}

//public class ConsoleMap : QueryMap<ConsoleDTO>
//{
//    public ConsoleMap()
//     {
//         // This map requires a single input: The user
//         RequireParam<User>("current_user");
        
//         // First get the open, unqueued items that I own
//         For(d => d.UnqueuedItemsCount)
//             .Count<WorkflowItem>(i => 
//                     i.Condition != "Closed" 
//                     && i.Owner == GetParam("current_user") 
//                     && i.Queue == null);
             
//         // Next get the open, queued items that I own
//         For(d => d.QueuedItemsCount)
//             .Count<WorkflowItem>(i => 
//                     i.Condition != "Closed" 
//                     && i.Owner == GetParam("current_user") 
//                     && i.Queue != null);
             
//         // Next, get the counts of each workflowitem by type (Case, Solution, etc)
//         // "GetWorkflowItemTypes()" is just a static method that returns a string[]
//         // and doesn't actually hit the DB
//         For(d => d.ByItemType).Each(GetWorkflowItemTypes())
//             .Project(m => 
//                          {
//                             m.For(b => b.BinName).Use(entityType => entityType.Name);
//                             m.For(b => b.ItemCount)
//                                   .Count<WorkflowItem>(i => 
//                                            i.Condition != "Closed" 
//                                            && i.Owner == GetParam("current_user") 
//                                            && i.Queue == null
//                          });
                  
//         // Next, get the list of queues that I'm a member of from the DB
//         // Then, for each queue, get the count of the number of open items in that queue
//         For(d => d.Queues)
//             .Fetch<Queue>(q => q.Members.Contains(GetParam("current_user")))
//             .Project(m => 
//                          {
//                             m.For(b => b.BinName).Use(q => q.Name);
//                             m.For(b => b.ItemCount)
//                                      .Count<WorkflowItem>(i => 
//                                                 i.Condition != "Closed" 
//                                                 && i.Queue == m.CurrentObject())
//                          });
                          

//         // Next, get the list of my tags and project the list with the counts of items
//         // in each tag
//         For(d => d.Tags)
//             .Fetch<Tag>(t => t.User == GetParam("current_user"))
//             .Project(m =>
//                          {
//                             m.GroupBy(t => t.Name).MapTo(b => b.BinName);
//                             m.For(b => b.ItemCount).Count();
//                          });

             
//     }
//}
        
        
    }
}