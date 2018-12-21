﻿using AlbumReview.Web.Helpers;

namespace AlbumReview.Web.Api.services
{
    public interface IPaginationUrlHelper
    {
        string CreateUrlForResource(RequestParameters requestParameter, PageType pageType, string routeName);
    }
}
