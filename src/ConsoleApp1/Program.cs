using System.Transactions;
using ConsoleApp1;

using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
var dbContext = new AppDbContext();
dbContext.Samples.Add(new Sample("Test"));
dbContext.SaveChanges();
scope.Complete();   // Have to call Complete() explicitly