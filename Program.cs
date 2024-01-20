
using Microsoft.EntityFrameworkCore;
using portfolio_bff.Models.Github;
using portfolio_bff.Models.Linkedin;
using portfolio_bff.Repositories;
using portfolio_bff.Repositories.Interfaces;
using portfolio_bff.Services;
using portfolio_bff.Services.Interfaces;
using System;

namespace portfolio_bff
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

            builder.Services.AddHttpClient();

            builder.Services.AddDbContext<PortfolioDbContext>(options =>
                options.UseNpgsql(connectionString));

            // Repositories
            builder.Services.AddScoped<LinkedinUserRepository>();
            builder.Services.AddScoped<GithubUserRepository>();

            // UserService com acesso direto aos repositórios específicos
            builder.Services.AddScoped<IUserService<LinkedInUser>, LinkedinUserService>();
            builder.Services.AddScoped<IUserService<GithubUser>, GithubUserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
