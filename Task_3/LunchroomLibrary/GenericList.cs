using System;
using System.Collections.Generic;

namespace LunchroomLibrary
{
    /// <summary>
    /// Обобщённый список.
    /// </summary>
    /// <typeparam name="T"> Тип объектов списка. </typeparam>
    public abstract class GenericList<T>
    {
        protected List<T> list;

        /// <summary>
        /// Инициализатор класса GenericList.
        /// </summary>
        public GenericList()
        {
            list = new List<T>();
        }

        /// <summary>
        /// Количество объектов.
        /// </summary>
        public int Count { get => list.Count; }

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="index"> Индекс объекта в списке. </param>
        /// <returns> Возвращает объект по указанному индексу. </returns>
        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return list[index];
            }
        }

        /// <summary>
        /// Проверка индекса на корректность.
        /// </summary>
        /// <param name="index"> Индекс. </param>
        private void CheckIndex(int index)
        {
            if ( (index < 0) || (index > list.Count - 1) )
            {
                throw new ArgumentException($"Индекс {this.GetType().Name} выходит за пределы диапазона списка.",
                    nameof(index));
            }
        }

        /// <summary>
        /// Добавить объект.
        /// </summary>
        /// <param name="obj"> Объект. </param>
        public virtual void AddObject(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException($"{this.GetType().Name} не был передан.");
            }

            list.Add(obj);
        }

        /// <summary>
        /// Удалить конкретный объект.
        /// </summary>
        /// <param name="obj"> Объект. </param>
        public void RemoveObject(T obj)
        {
            if (obj != null)
            {
                for (var i = 0; i < list.Count; i++)
                {
                    if (list[i].Equals(obj))
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }

        /// <summary>
        /// Удалить объект по индексу.
        /// </summary>
        /// <param name="index"> Индекс объекта. </param>
        public void RemoveObjectByIndex(int index)
        {
            CheckIndex(index);
            list.RemoveAt(index);
        }

        /// <summary>
        /// Удалить все объекты.
        /// </summary>
        public void RemoveAllObjects()
        {
            list.Clear();
        }     
    }
}
