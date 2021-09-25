using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace Forum_v1.Models
{
    public class TopicCreateViewModel
    {
        [Required]
        [Display(Name = "Наименование.")]
        public string TopicName { set; get; }

        [Required]
        [Display(Name = "Описание.")]
        public string TopicDescription { set; get; }
    }


     public class MessageCreateViewModel
    {
        [Display(Name ="Дата:")]
        public string Date { set; get; }

        [Display(Name = "Ваше имя:")]
        public string ClientName { set; get; }

        [Required]
        [Display(Name = "Ваше сообщение:")]
        [DataType(DataType.MultilineText)]
        public string Text { set; get; }

        public int TopicId { set; get; }

    }


    public class MessageEditViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { set; get; }

        [HiddenInput(DisplayValue = false)]
        public string ApplicationUserId { set; get; }


        [Display(Name = "Создан:")]
        public string DateOfCreate { set; get; }


        [Display(Name = "Изменен:")]
        public string DateOflastEdit { set; get; }


        [Display(Name = "Ваше имя:")]
        public string ClientName { set; get; }


        [Required]
        [Display(Name = "Ваше сообщение:")]
        [DataType(DataType.MultilineText)]
        public string Text { set; get; }

        public int TopicId { set; get; }

        public MessageEditViewModel() 
        {
            DateOflastEdit = DateTime.Now.ToString();        
        }

    }
}
