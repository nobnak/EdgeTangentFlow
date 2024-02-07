using Gist2.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ETF : System.IDisposable {

    protected ComputeShader cs;
    protected int k_sobel;

    public ETF() {
        cs = Resources.Load<ComputeShader>("ETF");
        k_sobel = cs.FindKernel("Sobel");
    }

    #region IDisposable
    public void Dispose() {
        Resources.UnloadAsset(cs);
    }
    #endregion

    #region declarations

    #endregion
}