﻿namespace Domain.Common
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; }
    }
}