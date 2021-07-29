using Mapster;
using MapsterConsoleExample.Domains;

namespace MapsterConsoleExample.MapsterRegisters
{
    public class MapsterFluentRegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            // config.AdaptTo("[name]Dto")
            //     // .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Mapster_Console_Example.Domains");
            //     .ForType<Course>()
            //     .ForType<Student>();
            //
            // config.GenerateMapper("[name]Mapper")
            //     .ForType<Course>()
            //     .ForType<Student>();

            // config.AdaptTo("[name]Dto")
            //     .ForType<Course>();
            // config.GenerateMapper("[name]Mapper")
            //     .ForType<Course>();
            //
            // config.AdaptTo("[name]Dto")
            //     .ForType<Student>();
            // config.GenerateMapper("[name]Mapper")
            //     .ForType<Student>(); 
        }
    }
}