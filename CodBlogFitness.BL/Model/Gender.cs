﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodBlogFitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Название
        /// </summary>
        [Serializable]
        public string Name { get; }
        /// <summary>
        /// Создать новый пол
        /// </summary>
        /// <param name="name">Имя пола</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Пол не может быть не заполненным",nameof(name);
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}