using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Authors
{
    class MainAuthors
    {
        private List<Author> Author = new List<Author>();
        private List<Specialization> Spec = new List<Specialization>();

        public void Init()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "");
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                Author.AddRange(CollectTypes<Author, AuthorAttribute>(asm));
                Spec.AddRange(CollectTypes<Specialization, SpecializationAttribute>(asm));
            }
        }

        public List<T> CollectTypes<T, TA>(Assembly asm)
            where TA : Attribute
        {
            var res = new List<T>();

            foreach (var type in asm.GetTypes())
            {
                var attr = type.GetCustomAttribute<TA>();
                if (attr != null)
                {
                    res.Add((T)Activator.CreateInstance(type));
                }
            }

            return res;
        }

        public List<Specialization> FindAllSpecialization()
        {
            return Spec;
        }
    }
}
