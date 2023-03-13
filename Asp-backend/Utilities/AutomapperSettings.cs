﻿using Models.Request;
using Models.Responce;

namespace AspBackend.Utilities
{
    public class AutomapperSettings: Profile
    {
        /// <summary>
        /// Метод для сопоставления типов при маппинге
        /// </summary>
        /// <returns>Настройки маппинга</returns>
        public static  MapperConfiguration RegisterMaps()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {

                config.CreateMap<UserRequest, User>().ReverseMap();
                config.CreateMap<UserResponce, User>().ReverseMap();


                config.CreateMap<UserRegistrationRequest, User>().ReverseMap();
                config.CreateMap<UserRegistrationResponce, User>().ReverseMap();

                config.CreateMap<UserRegistrationRequest, Account>().ReverseMap();
                config.CreateMap<UserRegistrationResponce, Account>().ReverseMap();

                config.CreateMap<UserAuthorizationRequest, User>().ReverseMap();
                config.CreateMap<UserAuthorizationResponce, User>().ReverseMap();

                config.CreateMap<UserAuthorizationRequest, Account>().ReverseMap();
                config.CreateMap<UserAuthorizationResponce, Account>().ReverseMap();

                #region Маппинг для создания задачи
                config.CreateMap<CreateTodoRequest, Todo>().ReverseMap();
                config.CreateMap<CreateTodoResponce, Todo>().ReverseMap();

                config.CreateMap<CreateTodoRequest, Status>().ReverseMap();
                config.CreateMap<CreateTodoResponce, Status>().ReverseMap();

                config.CreateMap<CreateTodoRequest, Priority>().ReverseMap();
                config.CreateMap<CreateTodoResponce, Priority>().ReverseMap();
                #endregion

                #region Маппинг для обновления задачи
                config.CreateMap<UpdateTodoRequest, Todo>().ReverseMap();
                config.CreateMap<UpdateTodoResponce, Todo>().ReverseMap();
                #endregion

                #region Маппинг для создания/удаления пользователя у задачи
                config.CreateMap<UserTodoRequest, UserTodo>().ReverseMap();
                config.CreateMap<UserTodoResponce, UserTodo>().ReverseMap();
                #endregion

                #region Маппинг для создания/удаления проектов
                config.CreateMap<ProjectRequest, Project>().ReverseMap();
                config.CreateMap<ProjectResponce, Project>().ReverseMap();
                #endregion

                #region Маппинг для создания/удаления задач у проекта
                config.CreateMap<ProjectTodoRequest, ProjectTodo>().ReverseMap();
                config.CreateMap<ProjectTodoResponce, ProjectTodo>().ReverseMap();
                #endregion

                #region Маппинг для добавление/удаления пользователей у проекта
                config.CreateMap<ProjectUserRequest, UserProject>().ReverseMap();
                config.CreateMap<ProjectUserResponce, UserProject>().ReverseMap();
                #endregion



            });

            return mapperConfig;
        }
    }
}