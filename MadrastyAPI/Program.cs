using  BusinessLogic.Abstractions;
using  BusinessLogic.Contexts;
using  BusinessLogic.Hubs;
using  BusinessLogic.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddSignalR();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
builder.Services.AddScoped<IDefinitionService, DefinitionService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<IUserprivilegesService, UserprivilegesService>();
builder.Services.AddScoped<Istudent_trackingService, student_trackingService>();
builder.Services.AddScoped<Iteacher_opinion_visitService, teacher_opinion_visitService>();
builder.Services.AddScoped<ImessagesService, messagesService>();
builder.Services.AddScoped<IswotService, swotService>();
builder.Services.AddScoped<ISchool_partyService, School_partyService>();
builder.Services.AddScoped<IEventsService, EventsService>();
builder.Services.AddScoped<IDaily_absence_statService, Daily_absence_statService>();
builder.Services.AddScoped<IViolation_recordService, Violation_recordService>();
builder.Services.AddScoped<IBehavioral_statusService, Behavioral_statusService>();
builder.Services.AddScoped<Icalling_parentsService, calling_parentsService>();
builder.Services.AddScoped<ISupervisor_opinionService, Supervisor_opinionService>();
builder.Services.AddScoped<IStudent_transferService, Student_transferService>();
builder.Services.AddScoped<IStudent_leaveService, Student_leaveService>();
builder.Services.AddScoped<Imeeting_typeService, meeting_typeService>();
builder.Services.AddScoped<ICatchRecieptService, CatchRecieptService>();
builder.Services.AddScoped<IPaymentRecieptServices, PaymentRecieptService>();
builder.Services.AddScoped<ISchoolServices, SchoolServices>();
builder.Services.AddScoped<ITa7dierService, Ta7dierService>();
builder.Services.AddScoped<ITa7dierJoinEmployeeService, Ta7dierJoinEmployeeService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddScoped<Iboard_typeService, board_typeService>();
builder.Services.AddScoped<Iboard_service, boardService>();


builder.Services.AddScoped<Istudent_status_behaviour_reportService, student_status_behaviour_reportService>();
builder.Services.AddScoped<Ibehaviours_statusService, behaviours_statusService>();
builder.Services.AddScoped<IHealth_casesService, Health_casesService>();
builder.Services.AddScoped<IAbsence_casesService, Absence_casesService>();
builder.Services.AddScoped<ISpeaking_disorderService, Speaking_disorderService>();

builder.Services.AddScoped<IRestToRedoService, RestToRedoService>();
builder.Services.AddScoped<IAccusedStudentsInGuiltService, AccusedStudentInGuiltService>();
builder.Services.AddScoped<ISonsOfMartyrsServices, SonsOfMartyrsServices>();
builder.Services.AddScoped<I_IndividualCasesServices, IndividualCasesServices>();
builder.Services.AddScoped<IOtherStudentSlidesServices, OtherStudentSlidesServices>();
builder.Services.AddScoped<IRegimeCouncilStudentServices, RegimeCouncilStudentServices>();
builder.Services.AddScoped<ISpecialStudentServices, SpecialStudentServices>();
builder.Services.AddScoped<IGuiltServices, GuiltServices>();
builder.Services.AddScoped<Iwork_planService, work_planService>();
builder.Services.AddScoped<Isignalir_connectionsService, signalir_connectionsService>();
builder.Services.AddScoped<I7sa_defService, _7sa_defService>();
builder.Services.AddScoped<IadvertsService, advertsService>();
builder.Services.AddScoped<Imonth_valueService, month_valueService>();
builder.Services.AddScoped<INewsServices, NewsServices>();
builder.Services.AddScoped<IenzratService, enzratService>();
//builder.Services.AddScoped<Hub<InotificationService>, notification>();
//builder.Services.AddSingleton<IHubContext<notification>, Microsoft.AspNetCore.SignalR.HubContext<notification>>();




//builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
//        builder =>
//        {
//            builder.AllowAnyHeader()
//                   .AllowAnyMethod()
//                   .SetIsOriginAllowed((host) => true)
//                   .AllowCredentials();
//        }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapHub<AppNotificationHub>("/Notify");
app.MapControllers();
app.Run();
