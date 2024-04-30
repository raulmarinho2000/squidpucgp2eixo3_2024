var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/squid/{endereco}/{acao}", async context =>
{
      var endereco = context.Request.RouteValues["endereco"];
      var acao = context.Request.RouteValues["acao"];
      System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo();
      process.UseShellExecute = false;
      process.WorkingDirectory = "/bin";
      process.FileName = "bash";
      process.Arguments = $"/home/administrator/bloquear.sh {endereco} {acao}";
      process.RedirectStandardOutput = true;

      System.Diagnostics.Process cmd =  System.Diagnostics.Process.Start(process);
      cmd.WaitForExit();


      await context.Response.WriteAsync($"endereco: {endereco}. acao: {acao}");
});

app.Run();
