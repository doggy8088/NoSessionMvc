using System;
using System.Collections.Generic;
using System.Web.Mvc;

public class NoTempDataProvider : ITempDataProvider
{
    #region [ ITempDataProvider Members ]

    public IDictionary<String, Object> LoadTempData(ControllerContext controllerContext)
    {
        return new Dictionary<String, Object>();
    }

    public void SaveTempData(ControllerContext controllerContext, IDictionary<String, Object> values) { }

    #endregion
}
