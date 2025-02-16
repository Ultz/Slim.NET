// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincred.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Win32.ERROR;
using static Silk.NET.Win32.NERR;
using static Silk.NET.Win32.SEC;
using static Silk.NET.Win32.STATUS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static bool CREDUI_IS_AUTHENTICATION_ERROR(int _Status)
    {
        return (
            CREDUIP_IS_USER_PASSWORD_ERROR(_Status)
            || CREDUIP_IS_DOWNGRADE_ERROR(_Status)
            || CREDUIP_IS_EXPIRED_ERROR(_Status)
        );
    }

    public static bool CREDUI_NO_PROMPT_AUTHENTICATION_ERROR(int _Status)
    {
        return (
            (_Status) == ERROR_AUTHENTICATION_FIREWALL_FAILED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_AUTHENTICATION_FIREWALL_FAILED)
            || (_Status) == STATUS_AUTHENTICATION_FIREWALL_FAILED
            || (_Status) == HRESULT_FROM_NT(STATUS_AUTHENTICATION_FIREWALL_FAILED)
            || (_Status) == ERROR_ACCOUNT_DISABLED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_ACCOUNT_DISABLED)
            || (_Status) == STATUS_ACCOUNT_DISABLED
            || (_Status) == HRESULT_FROM_NT(STATUS_ACCOUNT_DISABLED)
            || (_Status) == ERROR_ACCOUNT_RESTRICTION
            || (_Status) == HRESULT_FROM_WIN32(ERROR_ACCOUNT_RESTRICTION)
            || (_Status) == STATUS_ACCOUNT_RESTRICTION
            || (_Status) == HRESULT_FROM_NT(STATUS_ACCOUNT_RESTRICTION)
            || (_Status) == ERROR_ACCOUNT_LOCKED_OUT
            || (_Status) == HRESULT_FROM_WIN32(ERROR_ACCOUNT_LOCKED_OUT)
            || (_Status) == STATUS_ACCOUNT_LOCKED_OUT
            || (_Status) == HRESULT_FROM_NT(STATUS_ACCOUNT_LOCKED_OUT)
            || (_Status) == ERROR_ACCOUNT_EXPIRED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_ACCOUNT_EXPIRED)
            || (_Status) == STATUS_ACCOUNT_EXPIRED
            || (_Status) == HRESULT_FROM_NT(STATUS_ACCOUNT_EXPIRED)
            || (_Status) == ERROR_LOGON_TYPE_NOT_GRANTED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_LOGON_TYPE_NOT_GRANTED)
            || (_Status) == STATUS_LOGON_TYPE_NOT_GRANTED
            || (_Status) == HRESULT_FROM_NT(STATUS_LOGON_TYPE_NOT_GRANTED)
        );
    }

    public static bool CREDUIP_IS_DOWNGRADE_ERROR(int _Status)
    {
        return (
            (_Status) == ERROR_DOWNGRADE_DETECTED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_DOWNGRADE_DETECTED)
            || (_Status) == STATUS_DOWNGRADE_DETECTED
            || (_Status) == HRESULT_FROM_NT(STATUS_DOWNGRADE_DETECTED)
            || (_Status) == SEC_E_DOWNGRADE_DETECTED
        );
    }

    public static bool CREDUIP_IS_EXPIRED_ERROR(int _Status)
    {
        return (
            (_Status) == ERROR_PASSWORD_EXPIRED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_PASSWORD_EXPIRED)
            || (_Status) == STATUS_PASSWORD_EXPIRED
            || (_Status) == HRESULT_FROM_NT(STATUS_PASSWORD_EXPIRED)
            || (_Status) == ERROR_PASSWORD_MUST_CHANGE
            || (_Status) == HRESULT_FROM_WIN32(ERROR_PASSWORD_MUST_CHANGE)
            || (_Status) == STATUS_PASSWORD_MUST_CHANGE
            || (_Status) == HRESULT_FROM_NT(STATUS_PASSWORD_MUST_CHANGE)
            || (_Status) == NERR_PasswordExpired
            || (_Status) == HRESULT_FROM_WIN32(NERR_PasswordExpired)
        );
    }

    public static bool CREDUIP_IS_USER_PASSWORD_ERROR(int _Status)
    {
        return (
            (_Status) == ERROR_LOGON_FAILURE
            || (_Status) == HRESULT_FROM_WIN32(ERROR_LOGON_FAILURE)
            || (_Status) == STATUS_LOGON_FAILURE
            || (_Status) == HRESULT_FROM_NT(STATUS_LOGON_FAILURE)
            || (_Status) == ERROR_ACCESS_DENIED
            || (_Status) == HRESULT_FROM_WIN32(ERROR_ACCESS_DENIED)
            || (_Status) == STATUS_ACCESS_DENIED
            || (_Status) == HRESULT_FROM_NT(STATUS_ACCESS_DENIED)
            || (_Status) == ERROR_INVALID_PASSWORD
            || (_Status) == HRESULT_FROM_WIN32(ERROR_INVALID_PASSWORD)
            || (_Status) == STATUS_WRONG_PASSWORD
            || (_Status) == HRESULT_FROM_NT(STATUS_WRONG_PASSWORD)
            || (_Status) == STATUS_NO_SUCH_USER
            || (_Status) == HRESULT_FROM_NT(STATUS_NO_SUCH_USER)
            || (_Status) == ERROR_NO_SUCH_USER
            || (_Status) == HRESULT_FROM_WIN32(ERROR_NO_SUCH_USER)
            || (_Status) == ERROR_NO_SUCH_LOGON_SESSION
            || (_Status) == HRESULT_FROM_WIN32(ERROR_NO_SUCH_LOGON_SESSION)
            || (_Status) == STATUS_NO_SUCH_LOGON_SESSION
            || (_Status) == HRESULT_FROM_NT(STATUS_NO_SUCH_LOGON_SESSION)
            || (_Status) == SEC_E_NO_CREDENTIALS
            || (_Status) == SEC_E_LOGON_DENIED
            || (_Status) == SEC_E_NO_CONTEXT
            || (_Status) == STATUS_NO_SECURITY_CONTEXT
        );
    }
}
