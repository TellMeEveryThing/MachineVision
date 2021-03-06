﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HalconDotNet;



namespace QueXianJianCeLibrary
{
    #region  缺陷检测的数据
    /// <summary>
    /// 缺陷检测的数据
    /// </summary>
    public class QueXianJianCeShuJu : MultTree.ToolDateFather, IQueXianJianCeShuJu
    {
        #region  全局变量

        #region  提取ocv检测的region 点位
        /// <summary>
        /// 外部接口
        /// </summary>
        [NonSerialized]
        HalControl.ROI.Rectangle2.IOutsideRectangle2ROI _iOutSide = null;

        #endregion

        #region   创建模板参数
        /// <summary>
        /// 创建模板的黄金匹配层数
        /// </summary>
        HTuple numLevels = 5;

        /// <summary>
        /// 创建模板开始角度
        /// </summary>
        HTuple angleStart = HTuple.TupleRand(-10);

        /// <summary>
        /// 创建模板的结束角度
        /// </summary>
        HTuple angleEnd = HTuple.TupleRand(20);

        /// <summary>
        /// 创建模板角度的步长
        /// </summary>
        HTuple angleStep = 0;
        
        /// <summary>
        /// 创建算法优化
        /// </summary>
        HTuple optimization = "none";

        /// <summary>
        /// 创建模板的极性
        /// </summary>
        HTuple metric = "use_polarity";
        
        /// <summary>
        /// 创建模板的对比度
        /// </summary>
        HTuple contrast = 20;
        
        /// <summary>
        /// 最小对比度
        /// </summary>
        HTuple mincontrast = 10;

        /// <summary>
        /// 模板的id
        /// </summary>
        HTuple shapeModelID = null;
     
        #endregion

        #region  模板的路径
        /// <summary>
        /// 模板的路径
        /// </summary>
        public string path = null;
        
        #endregion

        #region   创建丝印模板的参数
        /// <summary>
        /// 创建丝印模板的图片的宽
        /// </summary>
        HTuple with = null;

        /// <summary>
        ///  创建丝印模板的图片的高
        /// </summary>
        HTuple height = null;


        /// <summary>
        /// 创建丝印模板的格式
        /// </summary>
        HTuple _tybe = "byte";
        
        /// <summary>
        /// 创建丝印模板的格式
        /// </summary>
        HTuple mode = "standard";

        /// <summary>
        /// 创建丝印模板句柄
        /// </summary>
        HTuple variationModelID = null;
       
        #endregion

        #region  模板点
        /// <summary>
        /// 模板点y
        /// </summary>
        HTuple rowRef = null;
       
        /// <summary>
        /// 模板点x
        /// </summary>
        HTuple columnRef = null;
        #endregion

        #region   模板查找参数



        #endregion
        
        #endregion

        #region 属性

        #region  外部接口
        /// <summary>
        /// 外部接口
        /// </summary>
        public HalControl.ROI.Rectangle2.IOutsideRectangle2ROI IOutSide
        {
            get { return _iOutSide; }
            set { _iOutSide = value; }
        }
        #endregion

        #region  创建模板参数

        /// <summary>
        /// 创建模板的黄金匹配层数
        /// </summary>
        public HTuple NumLevels
        {
            get { return numLevels; }
            set { numLevels = value; }
        }

        /// <summary>
        /// 创建模板开始角度
        /// </summary>
        public HTuple AngleStart
        {
            get { return angleStart; }
            set { angleStart = value; }
        }

        /// <summary>
        /// 创建模板的结束角度
        /// </summary>
        public HTuple AngleEnd
        {
            get { return angleEnd; }
            set { angleEnd = value; }
        }

        /// <summary>
        /// 创建模板角度的步长
        /// </summary>
        public HTuple AngleStep
        {
            get { return angleStep; }
            set { angleStep = value; }
        }

        /// <summary>
        /// 创建算法优化
        /// </summary>
        public HTuple Optimization
        {
            get { return optimization; }
            set { optimization = value; }
        }

        /// <summary>
        /// 创建模板的极性
        /// </summary>
        public HTuple Metric
        {
            get { return metric; }
            set { metric = value; }
        }

        /// <summary>
        /// 创建模板的对比度
        /// </summary>
        public HTuple Contrast
        {
            get { return contrast; }
            set { contrast = value; }
        }

        /// <summary>
        /// 最小对比度
        /// </summary>
        public HTuple Mincontrast
        {
            get { return mincontrast; }
            set { mincontrast = value; }
        }

        /// <summary>
        /// 模板的id
        /// </summary>
        public HTuple ShapeModelID
        {
            get { return shapeModelID; }
            set { shapeModelID = value; }
        }


        #endregion

        #region  创建丝印模板的参数
        /// <summary>
        /// 创建丝印模板的图片的宽
        /// </summary>
        public HTuple With
        {
            get { return with; }
            set { with = value; }
        }

        /// <summary>
        ///  创建丝印模板的图片的高
        /// </summary>
        public HTuple Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// 创建丝印模板的格式
        /// </summary>
        public HTuple Tybe
        {
            get { return _tybe; }
            set { _tybe = value; }
        }

        /// <summary>
        /// 创建丝印模板的格式
        /// </summary>
        public HTuple Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        /// <summary>
        /// 创建丝印模板句柄
        /// </summary>
        public HTuple VariationModelID
        {
            get { return variationModelID; }
            set { variationModelID = value; }
        }

        #endregion

        #region  模板点
        
        /// <summary>
        /// 模板点y
        /// </summary>
        public HTuple RowRef
        {
            get { return rowRef; }
            set { rowRef = value; }
        }

        /// <summary>
        /// 模板点x
        /// </summary>
        public HTuple ColumnRef
        {
            get { return columnRef; }
            set { columnRef = value; }
        }
        
        #endregion

        #endregion

        #region  保存数据
        /// <summary>
        /// 保存数据
        /// </summary>
        public override void save()
        {
            base.save();
        }
        #endregion

        #region   初始化
        /// <summary>
        /// 初始化
        /// </summary>
        public override void init()
        {
            base.init();                        
        }
        #endregion

        #region  检测
        /// <summary>
        /// 缺陷检测
        /// </summary>
        /// <param name="hwin"></param>
        /// <param name="Key"></param>
        /// <param name="_dictionary_resulte"></param>
        /// <returns></returns>
        public override bool analyze_show(HWindow hwin, string Key, ref Dictionary<string, object> _dictionary_resulte)
        {
            return base.analyze_show(hwin, Key, ref _dictionary_resulte);
        }
        #endregion

        #region  显示
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="hwin"></param>
        /// <returns></returns>
        public override bool show(HWindow hwin)
        {
            return base.show(hwin);
        }
        #endregion

    }
    #endregion

    #region  缺陷检测的接口
    /// <summary>
    /// 缺陷检测的接口
    /// </summary>
    public interface IQueXianJianCeShuJu : MultTree.IToolDateFather, HalControl.ROI.Rectangle2.IOutsideRectangle2
    {

    }
    #endregion

    #region   缺陷检测设置器
    /// <summary>
    /// 缺陷检测设置器
    /// </summary>
    public class Set_QueXianJianCe
    {
        #region  创建模板
        #endregion

        #region  保存模板
        #endregion


        
    }
    #endregion

    #region  缺陷检测的结果
    /// <summary>
    /// 缺陷检测的结果
    /// </summary>
    public class QueXianJianCe_Result
    {

    }
    #endregion

}
