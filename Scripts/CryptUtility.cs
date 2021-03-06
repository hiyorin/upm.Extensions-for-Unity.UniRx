﻿using System;
using UniRx;
using Utility = UnityExtensions.CryptUtility;

namespace UnityExtensions.UniRx
{
    public static partial class CryptUtility
    {
        public static IObservable<byte[]> EncryptAESWithECBAsync(byte[] src, byte[] key)
        {
            byte[] dst = null;
            return Observable.Start(() => Utility.EncryptAESWithECB(src, out dst, key))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<string> EncryptAESWithECBAsync(string src, string key)
        {
            string dst = null;
            return Observable.Start(() => Utility.EncryptAESWithECB(src, out dst, key))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<byte[]> DecryptAESWithECBAsync(byte[] src, byte[] key)
        {
            byte[] dst = null;
            return Observable.Start(() => Utility.DecryptAESWithECB(src, out dst, key))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<string> DecryptAESWithECBAsync(string src, string key)
        {
            string dst = null;
            return Observable.Start(() => Utility.DecryptAESWithECB(src, out dst, key))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<Tuple<byte[], byte[]>> EncryptAESWithCBCAsync(byte[] src, byte[] key, int encryptKeyCount)
        {
            byte[] iv = null;
            byte[] dst = null;
            return Observable.Start(() => Utility.EncryptAESWithCBC(src, key, encryptKeyCount, out iv, out dst))
                .ObserveOnMainThread()
                .Select(_ => Tuple.Create(iv, dst));
        }

        public static IObservable<Tuple<string, string>> EncryptAESWithABCAsync(string src, string key, int encryptKeyCount)
        {
            string iv = null;
            string dst = null;
            return Observable.Start(() => Utility.EncryptAESWithCBC(src, key, encryptKeyCount, out iv, out dst))
                .ObserveOnMainThread()
                .Select(_ => Tuple.Create(iv, dst));
        }

        public static IObservable<byte[]> DecryptAESWithCBCAsync(byte[] src, byte[] key, byte[] iv)
        {
            byte[] dst = null;
            return Observable.Start(() => Utility.DecryptAESWithCBC(src, key, iv, out dst))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<string> DecyptAESWithCBCAsync(string src, string key, string iv)
        {
            string dst = null;
            return Observable.Start(() => Utility.DecryptAESWithCBC(src, key, iv, out dst))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<byte[]> EncryptCRC32Async(byte[] src)
        {
            byte[] dst = null;
            return Observable.Start(() => Utility.EncryptCRC32(src, out dst))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }

        public static IObservable<string> EncryptCRC32Async(string src)
        {
            string dst = null;
            return Observable.Start(() => Utility.EncryptCRC32(src, out dst))
                .ObserveOnMainThread()
                .Select(_ => dst);
        }
    }
}
