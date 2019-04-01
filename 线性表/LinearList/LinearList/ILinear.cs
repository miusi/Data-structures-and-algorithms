using System;
using System.Collections.Generic;
using System.Text;

namespace LinearList
{
	public interface ILinear<T>
	{
		/// <summary>
		/// 初始化操作，建立一个空的线性表
		/// </summary>
		void InitList();

		/// <summary>
		/// 若线性表为空，返回true，否则返回false
		/// </summary>
		/// <returns></returns>
		bool IsEmpty();
		/// <summary>
		/// 将线性表清空
		/// </summary>
		void ClearList();

		/// <summary>
		/// 将线性表中的第i个位置元素值返回
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		T GetElement(int i);

		/// <summary>
		/// 在线性表中查找与给定值item相等的元素，如果查找成功，返回该元素在线性表中的序号
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		int LocateElem(T item);

		/// <summary>
		/// 将item插入到线性表指定位置
		/// </summary>
		/// <param name="item"></param>
		void Insert(T item,int i);

		/// <summary>
		/// 将元素插入到线性表尾
		/// </summary>
		/// <param name="item"></param>
		void Add(T item);

		/// <summary>
		/// 删除线性表中指定位置的元素
		/// </summary>
		/// <param name="i"></param>
		void Delete(int i);

		/// <summary>
		/// 线性表的长度
		/// </summary>
		/// <returns></returns>
		int Length();

	}
}
