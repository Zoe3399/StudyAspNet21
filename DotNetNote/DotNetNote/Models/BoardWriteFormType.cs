﻿namespace DotNetNote.Models
{
    public enum BoardWriteFormType
    {
        Write,      // 글 쓰기모드
        Modify,     // 글 수정모드
        Reply       // 댓글 모드
    }

    public enum ContentEncodingType
    {
        Text,       // 일반텍스트
        Html,       // HTML입력모드
        Mixed       // HTML입력 + 엔터키 모드
    }
}