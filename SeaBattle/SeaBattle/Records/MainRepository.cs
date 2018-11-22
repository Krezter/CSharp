using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Records
{
    class MainRepository
    {
        private List<GameRecord> GameRecords = new List<GameRecord>();

        public void Init()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "");
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                GameRecords.AddRange(CollectTypes<GameRecord, GameRecordAttribute>(asm));
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

        public List<GameRecord> FindAllRecords()
        {
            return GameRecords;
        }
    }
}
