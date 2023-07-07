using CompanyManagementSystem.Data;
using CompanyManagementSystem.DataAccess;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Microsoft.Extensions.Options;
using CompanyManagementSystem.API.Services.Benefits;
using CompanyManagementSystem.API.Services.Skills;
using CompanyManagementSystem.API.Services.Languages;
using CompanyManagementSystem.API.Services.WorkingPositions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using CompanyManagementSystem.API.Services.Users;
using CompanyManagementSystem.API.Services.Roles;
using CompanyManagementSystem.API.Services.Vacations;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
        opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };

                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(
                o =>
                {

                    o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is a sample secret key - please don't use in production environment.")),
                        ValidateIssuer = true,
                        ValidIssuer = "BogdanMilojevic",
                        ValidateAudience = true,
                        ValidAudience = "myAudience",
                        ValidateLifetime = false
                    };
                }
            );

builder.Services.AddAuthorization();

builder.Services.AddCors(options =>
    {
        options.AddPolicy(name: MyAllowSpecificOrigins,
            policy =>
            {
                policy
                .WithOrigins("http://localhost:4200", "http://localhost:5173")
                .AllowAnyMethod().AllowAnyHeader();
            });
    });

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IBenefitService, BenefitService>();
builder.Services.AddTransient<ISkillService, SkillService>();
builder.Services.AddTransient<IWorkingPositionService, WorkingPositionService>();
builder.Services.AddTransient<ILanguageService, LanguageService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<IVacationService, VacationService>();

var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

//app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
