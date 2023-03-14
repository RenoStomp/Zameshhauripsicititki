﻿using EPAMapp.Domain.Models.Entities;
using EPAMapp.Services.DTO.Update;

namespace EPAMapp.Services.Update
{
    public static class UpdateNote
    {
        public static async Task Update(Note note, DTOUpdateNote noteModel)
        {
            note.CurrentReport = noteModel.CurrentReport;
            note.UserId = noteModel.UserId;
        }
    }
}