using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            //GenerateRuntimeProcess("Test", 3000);

            string processName = "Hello2";
            AssemblyBuilder assemblyBuilder2 = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName() { Name = processName }, AssemblyBuilderAccess.Save);
            ModuleBuilder moduleBuilder2 = assemblyBuilder2.DefineDynamicModule(processName, processName + ".EXE");
            TypeBuilder typeBuilder = moduleBuilder2.DefineType("Program", TypeAttributes.Public);
            MethodBuilder methodBuilder = typeBuilder.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static, null, null);
            ILGenerator il = methodBuilder.GetILGenerator();
            //il.EmitWriteLine("Hello World");
            il.Emit(OpCodes.Ldstr, "Hello World");
            MethodInfo writeLineMethod = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) });
            il.Emit(OpCodes.Call, writeLineMethod);
            il.Emit(OpCodes.Ret);
            typeBuilder.CreateType();
            assemblyBuilder2.SetEntryPoint(methodBuilder.GetBaseDefinition(), PEFileKinds.ConsoleApplication);
            assemblyBuilder2.Save(processName + ".EXE", PortableExecutableKinds.Required32Bit, ImageFileMachine.I386);
        }

        private static CustomAttributeBuilder CreateAttributeBuilder()
        {
            return new CustomAttributeBuilder(
                typeof(System.STAThreadAttribute).GetConstructor(new Type[] { }),
                new object[] { });
        }

        public static Process GenerateRuntimeProcess(string processName, int aliveDuration, bool throwOnException = true)
        {
            Process result = null;
            try
            {
                AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName() { Name = processName }, AssemblyBuilderAccess.Save);
                ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(processName, processName + ".EXE");
                TypeBuilder typeBuilder = moduleBuilder.DefineType("Program", TypeAttributes.Public);
                MethodBuilder methodBuilder = typeBuilder.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static, null, null);
                ILGenerator il = methodBuilder.GetILGenerator();
                il.UsingNamespace("System.Threading");
                il.EmitWriteLine("Hello World");
                il.Emit(OpCodes.Ldc_I4, aliveDuration);
                il.Emit(OpCodes.Call, typeof(Thread).GetMethod("Sleep", new Type[] { typeof(int) }));
                il.Emit(OpCodes.Ret);
                typeBuilder.CreateType();
                assemblyBuilder.SetEntryPoint(methodBuilder.GetBaseDefinition(), PEFileKinds.ConsoleApplication);
                assemblyBuilder.Save(processName + ".EXE", PortableExecutableKinds.Required32Bit, ImageFileMachine.I386);
                result = Process.Start(new ProcessStartInfo(processName + ".EXE")
                {
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            catch
            {
                if (throwOnException)
                {
                    throw;
                }
                result = null;
            }
            return result;
        }
    }
}
