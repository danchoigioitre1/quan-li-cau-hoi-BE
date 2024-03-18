using MISA.EMIS.HOMEWORK.BL.Service;
using MISA.EMIS.HOMEWORK.BL.Service.AnswerService;
using MISA.EMIS.HOMEWORK.BL.Service.ExerciseService;
using MISA.EMIS.HOMEWORK.BL.Service.GradeService;
using MISA.EMIS.HOMEWORK.BL.Service.QuestionService;
using MISA.EMIS.HOMEWORK.BL.Service.SubjectService;
using MISA.EMIS.HOMEWORK.BL.Service.TopicService;
using MISA.EMIS.HOMEWORK.BLAPP.AnswerBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.ExerciseBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.GradeBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.QuestionBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.SubjectBLApp;
using MISA.EMIS.HOMEWORK.BLAPP.TopicBLApp;
using MISA.EMIS.HOMEWORK.COMMON.DataConection;
using MISA.EMIS.HOMEWORK.DL.Emis.Homework;
using MISA.EMIS.HOMEWORK.DL.Repository.AnswerRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.ExerciseRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.GradeRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.QuesitonRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.SubjectRepository;
using MISA.EMIS.HOMEWORK.DL.Repository.TopicRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddScoped<IEmisHomeworkRepository, EmisHomeworkRepository>();
//builder.Services.AddScoped<IEmisHomeworkService, EmisHomeworkService>();

builder.Services.AddScoped<IAnswerAppService, AnswerAppService>();
builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
builder.Services.AddScoped<IAnswerService, AnswerService>();

builder.Services.AddScoped<IQuestionAppService, QuestionAppService>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IQuestionService, QuestionService>();

builder.Services.AddScoped<IExerciseAppService, ExerciseAppService>();
builder.Services.AddScoped<IExerciseRepository, ExerciseRepository>();
builder.Services.AddScoped<IExerciseService, ExerciseService>();


builder.Services.AddScoped<IGradeAppService, GradeAppService>();
builder.Services.AddScoped<IGradeRepository, GradeRepository>();
builder.Services.AddScoped<IGradeService, GradeService>();

builder.Services.AddScoped<ITopicAppService, TopicAppService>();
builder.Services.AddScoped<ITopicRepository, TopicRepository>();
builder.Services.AddScoped<ITopicService, TopicService>();

builder.Services.AddScoped<ISubjectAppService, SubjectAppService>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ISubjectService, SubjectService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
