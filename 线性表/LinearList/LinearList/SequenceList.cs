using System;
using System.Collections.Generic;
using System.Text;

namespace LinearList
{
	public class SequenceList<T> : ILinear<T>
	{
		/// <summary>
		/// 最大容量
		/// </summary>
		private int MaxSize;
		/// <summary>
		/// 元素数组
		/// </summary>
		private T[] items;
		/// <summary>
		/// 当前指向最后一个元素位置
		/// </summary>
		private int Position;

		public SequenceList(int size)
		{
			MaxSize = size;
			this.items = new T[size];
			//初始值为-1，元素个数为0
			Position = -1;
		}

		public void Add(T item)
		{
			throw new NotImplementedException();
		}

		public void ClearList()
		{
			throw new NotImplementedException();
		}

		public void Delete(int i)
		{
			throw new NotImplementedException();
		}

		public T GetElement(int i)
		{
			throw new NotImplementedException();
		}

		public void InitList()
		{
			throw new NotImplementedException();
		}

		public void Insert(T item, int i)
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public int Length()
		{
			throw new NotImplementedException();
		}

		public int LocateElem(T item)
		{
			throw new NotImplementedException();
		}
	}
}
