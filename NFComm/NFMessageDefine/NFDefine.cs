// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NFDefine.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NFMsg {

  /// <summary>Holder for reflection information generated from NFDefine.proto</summary>
  public static partial class NFDefineReflection {

    #region Descriptor
    /// <summary>File descriptor for NFDefine.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NFDefineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5ORkRlZmluZS5wcm90bxIFTkZNc2cqswMKDkVHYW1lRXZlbnRDb2RlEgsK",
            "B1NVQ0NFU1MQABIQCgxVTktPV05fRVJST1IQARIRCg1BQ0NPVU5UX0VYSVNU",
            "EAISFgoSQUNDT1VOVFBXRF9JTlZBTElEEAMSEQoNQUNDT1VOVF9VU0lORxAE",
            "EhIKDkFDQ09VTlRfTE9DS0VEEAUSEwoPQUNDT1VOVF9TVUNDRVNTEAYSFgoS",
            "VkVSSUZZX0tFWV9TVUNDRVNTEAcSEwoPVkVSSUZZX0tFWV9GQUlMEAgSGAoU",
            "U0VMRUNUU0VSVkVSX1NVQ0NFU1MQCRIVChFTRUxFQ1RTRVJWRVJfRkFJTBAK",
            "EhMKD0NIQVJBQ1RFUl9FWElTVBBuEhUKEVNWUlpPTkVJRF9JTlZBTElEEG8S",
            "FAoQQ0hBUkFDVEVSX05VTU9VVBBwEhUKEUNIQVJBQ1RFUl9JTlZBTElEEHES",
            "FgoSQ0hBUkFDVEVSX05PVEVYSVNUEHISEwoPQ0hBUkFDVEVSX1VTSU5HEHMS",
            "FAoQQ0hBUkFDVEVSX0xPQ0tFRBB0EhEKDVpPTkVfT1ZFUkxPQUQQdRIOCgpO",
            "T1RfT05MSU5FEHYq6Q8KCkVHYW1lTXNnSUQSCgoGVU5LTk9XEAASEAoMRVZF",
            "TlRfUkVTVUxUEAESEwoPRVZFTlRfVFJBTlNQT1JUEAISEAoMQ0xPU0VfU09D",
            "S0VUEAMSGAoUV1RNX1dPUkxEX1JFR0lTVEVSRUQQChIaChZXVE1fV09STERf",
            "VU5SRUdJU1RFUkVEEAsSFQoRV1RNX1dPUkxEX1JFRlJFU0gQDBIYChRMVE1f",
            "TE9HSU5fUkVHSVNURVJFRBAUEhoKFkxUTV9MT0dJTl9VTlJFR0lTVEVSRUQQ",
            "FRIVChFMVE1fTE9HSU5fUkVGUkVTSBAWEhkKFVBUV0dfUFJPWFlfUkVHSVNU",
            "RVJFRBAeEhsKF1BUV0dfUFJPWFlfVU5SRUdJU1RFUkVEEB8SFgoSUFRXR19Q",
            "Uk9YWV9SRUZSRVNIECASFwoTR1RXX0dBTUVfUkVHSVNURVJFRBAoEhkKFUdU",
            "V19HQU1FX1VOUkVHSVNURVJFRBApEhQKEEdUV19HQU1FX1JFRlJFU0gQKhIV",
            "ChFEVFdfREJfUkVHSVNURVJFRBA8EhcKE0RUV19EQl9VTlJFR0lTVEVSRUQQ",
            "PRISCg5EVFdfREJfUkVGUkVTSBA+EhAKDFNUU19ORVRfSU5GTxBGEhAKDFJF",
            "UV9MQUdfVEVTVBBQEhUKEUFDS19HQVRFX0xBR19URVNUEFESFQoRQUNLX0dB",
            "TUVfTEFHX1RFU1QQUhIVChFTVFNfU0VSVkVSX1JFUE9SVBBaEhIKDlNUU19I",
            "RUFSVF9CRUFUEGQSDQoJUkVRX0xPR0lOEGUSDQoJQUNLX0xPR0lOEGYSDgoK",
            "UkVRX0xPR09VVBBnEhIKDlJFUV9XT1JMRF9MSVNUEG4SEgoOQUNLX1dPUkxE",
            "X0xJU1QQbxIVChFSRVFfQ09OTkVDVF9XT1JMRBBwEhUKEUFDS19DT05ORUNU",
            "X1dPUkxEEHESGQoVUkVRX0tJQ0tFRF9GUk9NX1dPUkxEEHISEwoPUkVRX0NP",
            "Tk5FQ1RfS0VZEHgSEwoPQUNLX0NPTk5FQ1RfS0VZEHoSFgoRUkVRX1NFTEVD",
            "VF9TRVJWRVIQggESFgoRQUNLX1NFTEVDVF9TRVJWRVIQgwESEgoNUkVRX1JP",
            "TEVfTElTVBCEARISCg1BQ0tfUk9MRV9MSVNUEIUBEhQKD1JFUV9DUkVBVEVf",
            "Uk9MRRCGARIUCg9SRVFfREVMRVRFX1JPTEUQhwESFQoQUkVRX1JFQ09WRVJf",
            "Uk9MRRCIARIXChJSRVFfTE9BRF9ST0xFX0RBVEEQjAESFwoSQUNLX0xPQURf",
            "Uk9MRV9EQVRBEI0BEhcKElJFUV9TQVZFX1JPTEVfREFUQRCOARIXChJBQ0tf",
            "U0FWRV9ST0xFX0RBVEEQjwESEwoOUkVRX0VOVEVSX0dBTUUQlgESEwoOQUNL",
            "X0VOVEVSX0dBTUUQlwESEwoOUkVRX0xFQVZFX0dBTUUQmAESEwoOQUNLX0xF",
            "QVZFX0dBTUUQmQESEwoOUkVRX1NXQVBfU0NFTkUQmwESEwoOQUNLX1NXQVBf",
            "U0NFTkUQnAESGAoTUkVRX1NXQVBfSE9NRV9TQ0VORRCdARIYChNBQ0tfU1dB",
            "UF9IT01FX1NDRU5FEJ4BEhoKFVJFUV9FTlRFUl9HQU1FX0ZJTklTSBCfARIa",
            "ChVBQ0tfRU5URVJfR0FNRV9GSU5JU0gQoAESFQoQQUNLX09CSkVDVF9FTlRS",
            "WRDIARIVChBBQ0tfT0JKRUNUX0xFQVZFEMkBEh4KGUFDS19PQkpFQ1RfUFJP",
            "UEVSVFlfRU5UUlkQygESHAoXQUNLX09CSkVDVF9SRUNPUkRfRU5UUlkQywES",
            "FQoQQUNLX1BST1BFUlRZX0lOVBDSARIXChJBQ0tfUFJPUEVSVFlfRkxPQVQQ",
            "0wESGAoTQUNLX1BST1BFUlRZX1NUUklORxDUARIYChNBQ0tfUFJPUEVSVFlf",
            "T0JKRUNUENYBEhkKFEFDS19QUk9QRVJUWV9WRUNUT1IyENcBEhkKFEFDS19Q",
            "Uk9QRVJUWV9WRUNUT1IzENgBEhcKEkFDS19QUk9QRVJUWV9DTEVBUhDZARIQ",
            "CgtBQ0tfQUREX1JPVxDcARITCg5BQ0tfUkVNT1ZFX1JPVxDdARIRCgxBQ0tf",
            "U1dBUF9ST1cQ3gESEwoOQUNLX1JFQ09SRF9JTlQQ3wESFQoQQUNLX1JFQ09S",
            "RF9GTE9BVBDgARIWChFBQ0tfUkVDT1JEX1NUUklORxDiARIWChFBQ0tfUkVD",
            "T1JEX09CSkVDVBDjARIXChJBQ0tfUkVDT1JEX1ZFQ1RPUjIQ5AESFwoSQUNL",
            "X1JFQ09SRF9WRUNUT1IzEOUBEhUKEEFDS19SRUNPUkRfQ0xFQVIQ+gESFAoP",
            "QUNLX1JFQ09SRF9TT1JUEPsBEhYKEUFDS19EQVRBX0ZJTklTSEVEEIQCEg0K",
            "CFJFUV9NT1ZFEKwCEg0KCEFDS19NT1ZFEK0CEg0KCFJFUV9DSEFUEN4CEg0K",
            "CEFDS19DSEFUEN8CEhYKEVJFUV9TS0lMTF9PQkpFQ1RYEJADEhYKEUFDS19T",
            "S0lMTF9PQkpFQ1RYEJEDEhIKDVJFUV9TS0lMTF9QT1MQkgMSEgoNQUNLX1NL",
            "SUxMX1BPUxCTAxIWChFBQ0tfT05MSU5FX05PVElGWRDYBBIXChJBQ0tfT0ZG",
            "TElORV9OT1RJRlkQ2QQqRwoJRUl0ZW1UeXBlEg0KCUVJVF9FUVVJUBAAEgsK",
            "B0VJVF9HRU0QARIOCgpFSVRfU1VQUExZEAISDgoKRUlUX1NDUk9MTBADKrcB",
            "CgpFU2tpbGxUeXBlEhYKEkJSSUVGX1NJTkdMRV9TS0lMTBAAEhUKEUJSSUVG",
            "X0dST1VQX1NLSUxMEAESFwoTQlVMTEVUX1NJTkdMRV9TS0lMTBACEhgKFEJV",
            "TExFVF9SRUJPVU5EX1NLSUxMEAMSHAoYQlVMTEVUX1RBUkdFVF9CT01CX1NL",
            "SUxMEAQSGQoVQlVMTEVUX1BPU19CT01CX1NLSUxMEAUSDgoKRlVOQ19TS0lM",
            "TBAGKk0KCkVTY2VuZVR5cGUSEAoMTk9STUFMX1NDRU5FEAASFgoSU0lOR0xF",
            "X0NMT05FX1NDRU5FEAESFQoRTVVMVElfQ0xPTkVfU0NFTkUQAipGCghFTlBD",
            "VHlwZRIOCgpOT1JNQUxfTlBDEAASDAoISEVST19OUEMQARIOCgpUVVJSRVRf",
            "TlBDEAISDAoIRlVOQ19OUEMQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NFMsg.EGameEventCode), typeof(global::NFMsg.EGameMsgID), typeof(global::NFMsg.EItemType), typeof(global::NFMsg.ESkillType), typeof(global::NFMsg.ESceneType), typeof(global::NFMsg.ENPCType), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///events
  /// </summary>
  public enum EGameEventCode {
    /// <summary>
    /// </summary>
    [pbr::OriginalName("SUCCESS")] Success = 0,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("UNKOWN_ERROR")] UnkownError = 1,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACCOUNT_EXIST")] AccountExist = 2,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACCOUNTPWD_INVALID")] AccountpwdInvalid = 3,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACCOUNT_USING")] AccountUsing = 4,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACCOUNT_LOCKED")] AccountLocked = 5,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACCOUNT_SUCCESS")] AccountSuccess = 6,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("VERIFY_KEY_SUCCESS")] VerifyKeySuccess = 7,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("VERIFY_KEY_FAIL")] VerifyKeyFail = 8,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("SELECTSERVER_SUCCESS")] SelectserverSuccess = 9,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("SELECTSERVER_FAIL")] SelectserverFail = 10,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("CHARACTER_EXIST")] CharacterExist = 110,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("SVRZONEID_INVALID")] SvrzoneidInvalid = 111,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("CHARACTER_NUMOUT")] CharacterNumout = 112,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("CHARACTER_INVALID")] CharacterInvalid = 113,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("CHARACTER_NOTEXIST")] CharacterNotexist = 114,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("CHARACTER_USING")] CharacterUsing = 115,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("CHARACTER_LOCKED")] CharacterLocked = 116,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ZONE_OVERLOAD")] ZoneOverload = 117,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("NOT_ONLINE")] NotOnline = 118,
  }

  public enum EGameMsgID {
    /// <summary>
    /// </summary>
    [pbr::OriginalName("UNKNOW")] Unknow = 0,
    /// <summary>
    /// for events
    /// </summary>
    [pbr::OriginalName("EVENT_RESULT")] EventResult = 1,
    /// <summary>
    /// for events
    /// </summary>
    [pbr::OriginalName("EVENT_TRANSPORT")] EventTransport = 2,
    /// <summary>
    /// want to close some one
    /// </summary>
    [pbr::OriginalName("CLOSE_SOCKET")] CloseSocket = 3,
    [pbr::OriginalName("WTM_WORLD_REGISTERED")] WtmWorldRegistered = 10,
    [pbr::OriginalName("WTM_WORLD_UNREGISTERED")] WtmWorldUnregistered = 11,
    [pbr::OriginalName("WTM_WORLD_REFRESH")] WtmWorldRefresh = 12,
    [pbr::OriginalName("LTM_LOGIN_REGISTERED")] LtmLoginRegistered = 20,
    [pbr::OriginalName("LTM_LOGIN_UNREGISTERED")] LtmLoginUnregistered = 21,
    [pbr::OriginalName("LTM_LOGIN_REFRESH")] LtmLoginRefresh = 22,
    [pbr::OriginalName("PTWG_PROXY_REGISTERED")] PtwgProxyRegistered = 30,
    [pbr::OriginalName("PTWG_PROXY_UNREGISTERED")] PtwgProxyUnregistered = 31,
    [pbr::OriginalName("PTWG_PROXY_REFRESH")] PtwgProxyRefresh = 32,
    [pbr::OriginalName("GTW_GAME_REGISTERED")] GtwGameRegistered = 40,
    [pbr::OriginalName("GTW_GAME_UNREGISTERED")] GtwGameUnregistered = 41,
    [pbr::OriginalName("GTW_GAME_REFRESH")] GtwGameRefresh = 42,
    [pbr::OriginalName("DTW_DB_REGISTERED")] DtwDbRegistered = 60,
    [pbr::OriginalName("DTW_DB_UNREGISTERED")] DtwDbUnregistered = 61,
    [pbr::OriginalName("DTW_DB_REFRESH")] DtwDbRefresh = 62,
    [pbr::OriginalName("STS_NET_INFO")] StsNetInfo = 70,
    [pbr::OriginalName("REQ_LAG_TEST")] ReqLagTest = 80,
    [pbr::OriginalName("ACK_GATE_LAG_TEST")] AckGateLagTest = 81,
    [pbr::OriginalName("ACK_GAME_LAG_TEST")] AckGameLagTest = 82,
    [pbr::OriginalName("STS_SERVER_REPORT")] StsServerReport = 90,
    [pbr::OriginalName("STS_HEART_BEAT")] StsHeartBeat = 100,
    /// <summary>
    ///////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    [pbr::OriginalName("REQ_LOGIN")] ReqLogin = 101,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_LOGIN")] AckLogin = 102,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_LOGOUT")] ReqLogout = 103,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_WORLD_LIST")] ReqWorldList = 110,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_WORLD_LIST")] AckWorldList = 111,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_CONNECT_WORLD")] ReqConnectWorld = 112,
    [pbr::OriginalName("ACK_CONNECT_WORLD")] AckConnectWorld = 113,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_KICKED_FROM_WORLD")] ReqKickedFromWorld = 114,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_CONNECT_KEY")] ReqConnectKey = 120,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_CONNECT_KEY")] AckConnectKey = 122,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_SELECT_SERVER")] ReqSelectServer = 130,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_SELECT_SERVER")] AckSelectServer = 131,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_ROLE_LIST")] ReqRoleList = 132,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_ROLE_LIST")] AckRoleList = 133,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_CREATE_ROLE")] ReqCreateRole = 134,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_DELETE_ROLE")] ReqDeleteRole = 135,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_RECOVER_ROLE")] ReqRecoverRole = 136,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_LOAD_ROLE_DATA")] ReqLoadRoleData = 140,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_LOAD_ROLE_DATA")] AckLoadRoleData = 141,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_SAVE_ROLE_DATA")] ReqSaveRoleData = 142,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_SAVE_ROLE_DATA")] AckSaveRoleData = 143,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_ENTER_GAME")] ReqEnterGame = 150,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_ENTER_GAME")] AckEnterGame = 151,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_LEAVE_GAME")] ReqLeaveGame = 152,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_LEAVE_GAME")] AckLeaveGame = 153,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_SWAP_SCENE")] ReqSwapScene = 155,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_SWAP_SCENE")] AckSwapScene = 156,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_SWAP_HOME_SCENE")] ReqSwapHomeScene = 157,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_SWAP_HOME_SCENE")] AckSwapHomeScene = 158,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("REQ_ENTER_GAME_FINISH")] ReqEnterGameFinish = 159,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_ENTER_GAME_FINISH")] AckEnterGameFinish = 160,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_OBJECT_ENTRY")] AckObjectEntry = 200,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_OBJECT_LEAVE")] AckObjectLeave = 201,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_OBJECT_PROPERTY_ENTRY")] AckObjectPropertyEntry = 202,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_OBJECT_RECORD_ENTRY")] AckObjectRecordEntry = 203,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_PROPERTY_INT")] AckPropertyInt = 210,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_PROPERTY_FLOAT")] AckPropertyFloat = 211,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ACK_PROPERTY_STRING")] AckPropertyString = 212,
    /// <summary>
    ///EGMI_ACK_PROPERTY_DOUBLE				= 213;			//
    /// </summary>
    [pbr::OriginalName("ACK_PROPERTY_OBJECT")] AckPropertyObject = 214,
    [pbr::OriginalName("ACK_PROPERTY_VECTOR2")] AckPropertyVector2 = 215,
    [pbr::OriginalName("ACK_PROPERTY_VECTOR3")] AckPropertyVector3 = 216,
    [pbr::OriginalName("ACK_PROPERTY_CLEAR")] AckPropertyClear = 217,
    [pbr::OriginalName("ACK_ADD_ROW")] AckAddRow = 220,
    [pbr::OriginalName("ACK_REMOVE_ROW")] AckRemoveRow = 221,
    [pbr::OriginalName("ACK_SWAP_ROW")] AckSwapRow = 222,
    [pbr::OriginalName("ACK_RECORD_INT")] AckRecordInt = 223,
    [pbr::OriginalName("ACK_RECORD_FLOAT")] AckRecordFloat = 224,
    /// <summary>
    ///EGMI_ACK_RECORD_DOUBLE				= 225;
    /// </summary>
    [pbr::OriginalName("ACK_RECORD_STRING")] AckRecordString = 226,
    [pbr::OriginalName("ACK_RECORD_OBJECT")] AckRecordObject = 227,
    [pbr::OriginalName("ACK_RECORD_VECTOR2")] AckRecordVector2 = 228,
    [pbr::OriginalName("ACK_RECORD_VECTOR3")] AckRecordVector3 = 229,
    [pbr::OriginalName("ACK_RECORD_CLEAR")] AckRecordClear = 250,
    [pbr::OriginalName("ACK_RECORD_SORT")] AckRecordSort = 251,
    [pbr::OriginalName("ACK_DATA_FINISHED")] AckDataFinished = 260,
    [pbr::OriginalName("REQ_MOVE")] ReqMove = 300,
    [pbr::OriginalName("ACK_MOVE")] AckMove = 301,
    [pbr::OriginalName("REQ_CHAT")] ReqChat = 350,
    [pbr::OriginalName("ACK_CHAT")] AckChat = 351,
    [pbr::OriginalName("REQ_SKILL_OBJECTX")] ReqSkillObjectx = 400,
    [pbr::OriginalName("ACK_SKILL_OBJECTX")] AckSkillObjectx = 401,
    [pbr::OriginalName("REQ_SKILL_POS")] ReqSkillPos = 402,
    [pbr::OriginalName("ACK_SKILL_POS")] AckSkillPos = 403,
    [pbr::OriginalName("ACK_ONLINE_NOTIFY")] AckOnlineNotify = 600,
    [pbr::OriginalName("ACK_OFFLINE_NOTIFY")] AckOfflineNotify = 601,
  }

  public enum EItemType {
    /// <summary>
    ///the equipment which can add props
    /// </summary>
    [pbr::OriginalName("EIT_EQUIP")] EitEquip = 0,
    /// <summary>
    ///the gem ca be embed to the equipment
    /// </summary>
    [pbr::OriginalName("EIT_GEM")] EitGem = 1,
    /// <summary>
    ///expendable items for player, such as a medicine that cures
    /// </summary>
    [pbr::OriginalName("EIT_SUPPLY")] EitSupply = 2,
    /// <summary>
    ///special items that can call a hero or others, special items can do what you want to do
    /// </summary>
    [pbr::OriginalName("EIT_SCROLL")] EitScroll = 3,
  }

  public enum ESkillType {
    /// <summary>
    ///this kind of skill just can damage one object
    /// </summary>
    [pbr::OriginalName("BRIEF_SINGLE_SKILL")] BriefSingleSkill = 0,
    /// <summary>
    ///this kind of skill can damage multiple objects
    /// </summary>
    [pbr::OriginalName("BRIEF_GROUP_SKILL")] BriefGroupSkill = 1,
    /// <summary>
    ///this kind of bullet just can damage one object
    /// </summary>
    [pbr::OriginalName("BULLET_SINGLE_SKILL")] BulletSingleSkill = 2,
    /// <summary>
    ///this kind of bullet can damage multiple objects via rebound
    /// </summary>
    [pbr::OriginalName("BULLET_REBOUND_SKILL")] BulletReboundSkill = 3,
    /// <summary>
    ///this kind of bullet can damage multiple objects who around the target when the bullet touched the target object
    /// </summary>
    [pbr::OriginalName("BULLET_TARGET_BOMB_SKILL")] BulletTargetBombSkill = 4,
    /// <summary>
    ///this kind of bullet can damage multiple objects  who around the target when the bullet arrived the position
    /// </summary>
    [pbr::OriginalName("BULLET_POS_BOMB_SKILL")] BulletPosBombSkill = 5,
    [pbr::OriginalName("FUNC_SKILL")] FuncSkill = 6,
  }

  public enum ESceneType {
    /// <summary>
    ///public town, only has one group available for players is 1
    /// </summary>
    [pbr::OriginalName("NORMAL_SCENE")] NormalScene = 0,
    /// <summary>
    ///private room, only has one player per group and it will be destroyed if the player leaved from group.
    /// </summary>
    [pbr::OriginalName("SINGLE_CLONE_SCENE")] SingleCloneScene = 1,
    /// <summary>
    ///private room, only has more than one player per group and it will be destroyed if all players leaved from group.
    /// </summary>
    [pbr::OriginalName("MULTI_CLONE_SCENE")] MultiCloneScene = 2,
  }

  public enum ENPCType {
    /// <summary>
    /// </summary>
    [pbr::OriginalName("NORMAL_NPC")] NormalNpc = 0,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("HERO_NPC")] HeroNpc = 1,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("TURRET_NPC")] TurretNpc = 2,
    /// <summary>
    /// </summary>
    [pbr::OriginalName("FUNC_NPC")] FuncNpc = 3,
  }

  #endregion

}

#endregion Designer generated code
