﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
	[EntityTable(AccessLevel.WriteOnly, DbConfig.Log, "LogActionVisitor")]
    public class LogActionVisitor : LogEntity
    {
        #region auto-generated static method
        static LogActionVisitor()
        {
            EntitySchemaSet.InitSchema(typeof(LogActionVisitor));
        }
        #endregion
        /// <summary>
        /// </summary>
        public LogActionVisitor()
        {
            
        }        
        /// <summary>
        /// </summary>
        public LogActionVisitor(long logID)
            : this()
        {
            _logID = logID;
        }

        #region 自动生成属性
        private long _logID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("LogID", IsKey = true, IsIdentity = true)]
        public long LogID
        {
            get
            {
                return _logID;
            } 
        }
        private string _userID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("UserID")]
        public string UserID
        {
            set
            {
                SetChange("UserID", value);
            }
        }
        private int _actionID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("ActionID")]
        public int ActionID
        {
            set
            {
                SetChange("ActionID", value);
            }
        }
        private int _actionStat;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("ActionStat")]
        public int ActionStat
        {
            set
            {
                SetChange("ActionStat", value);
            }
        }
        private string _visitUrl;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("VisitUrl")]
        public string VisitUrl
        {
            set
            {
                SetChange("VisitUrl", value);
            }
        }
        private string _respCont;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("RespCont")]
        public string RespCont
        {
            set
            {
                SetChange("RespCont", value);
            }
        }
        private string _iP;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("IP")]
        public string IP
        {
            set
            {
                SetChange("IP", value);
            }
        }
        private DateTime _visitBeginTime;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("VisitBeginTime")]
        public DateTime VisitBeginTime
        {
            set
            {
                SetChange("VisitBeginTime", value);
            }
        }
        private DateTime _visitEndTime;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("VisitEndTime")]
        public DateTime VisitEndTime
        {
            set
            {
                SetChange("VisitEndTime", value);
            }
        }
        private DateTime _addtime;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("Addtime")]
        public DateTime Addtime
        {
            set
            {
                SetChange("Addtime", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "LogID": return _logID;
                    case "UserID": return _userID;
                    case "ActionID": return _actionID;
                    case "ActionStat": return _actionStat;
                    case "VisitUrl": return _visitUrl;
                    case "RespCont": return _respCont;
                    case "IP": return _iP;
                    case "VisitBeginTime": return _visitBeginTime;
                    case "VisitEndTime": return _visitEndTime;
                    case "Addtime": return _addtime;
					default: throw new ArgumentException(string.Format("LogActionVisitor index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "LogID": 
                        _logID = MathUtils.ToLong(value);
                        break; 
                    case "UserID": 
                        _userID = value.ToNotNullString();
                        break; 
                    case "ActionID": 
                        _actionID = value.ToInt();
                        break; 
                    case "ActionStat": 
                        _actionStat = value.ToInt();
                        break; 
                    case "VisitUrl": 
                        _visitUrl = value.ToNotNullString();
                        break; 
                    case "RespCont": 
                        _respCont = value.ToNotNullString();
                        break; 
                    case "IP": 
                        _iP = value.ToNotNullString();
                        break; 
                    case "VisitBeginTime": 
                        _visitBeginTime = value.ToDateTime();
                        break; 
                    case "VisitEndTime": 
                        _visitEndTime = value.ToDateTime();
                        break; 
                    case "Addtime": 
                        _addtime = value.ToDateTime();
                        break; 
					default: throw new ArgumentException(string.Format("LogActionVisitor index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}