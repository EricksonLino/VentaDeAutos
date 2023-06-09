﻿using VentaDeAutos.Application.Dtos;

namespace VentaDeAutos.Application.Interfaces
{
    public interface IAutoCedanApplication 
    {
        Task<List<AutoCedanDto>> ListarAutos();
        Task<AutoCedanDetalleDto> ObtenerAuto(int id);
        Task InsertarAutoCedan(AutoCedanCreacionDto autoCedanCreacionDto);
        Task EliminarAutoCedan(int id);
        Task ActualizarAutoCedan(int id, AutoCedanActualizarDto autoCedanActualizarDto);
    }
}
