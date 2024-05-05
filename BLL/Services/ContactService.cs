using BLL.Dto;
using DAL;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ContactService
    {
        DataBaseContext context = new DataBaseContext();

        /// <summary>
        /// دریافت لیست مخاطبان
        /// </summary>
        /// <returns></returns>
        public List<ContactListDto> GetContactLists()
        {
            var contacts = context.Contacts.Select(p => new ContactListDto
            {
                FullName = $"{p.Name} {p.LastName}",
                PhoneNumber = p.PhoneNumber,
                Id = p.Id,
                Company = p.Company
            }).ToList();
            return contacts;
        }

        /// <summary>
        /// جستجو مخاطب
        /// </summary>
        /// <param name="SearchKey"></param>
        /// <returns></returns>
        public List<ContactListDto> SearchContact(string SearchKey)
        {
            var ContactQuery = context.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            {
                ContactQuery = ContactQuery.Where(
                    p =>
                        p.Name.Contains(SearchKey)
                        ||
                        p.LastName.Contains(SearchKey)
                        ||
                        p.PhoneNumber.Contains(SearchKey)
                        ||
                        p.Company.Contains(SearchKey)
                );

            }

            var data = ContactQuery.Select(p => new ContactListDto
            {
                FullName = $"{p.Name} {p.LastName}",
                PhoneNumber = p.PhoneNumber,
                Id = p.Id,
                Company = p.Company
            }).ToList();
            return data;
        }

        public ResultDto DeleteContact(int Id)
        {
            var contact = context.Contacts.Find(Id);
            if (contact != null)
            {
                context.Remove(contact);
                context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "مخاطب با موفقیت حذف شد."
                };
            }
            return new ResultDto
            {
                IsSuccess = false,
                Message = "مخاطب یافت نشد"
            };
        }

        public ResultDto<ContactDetailDto> GetContactDetatil(int Id)
        {
            var contact = context.Contacts.Find(Id);
            if (contact == null)
            {
                return new ResultDto<ContactDetailDto>
                {
                    IsSuccess = false,
                    Message = "مخاطب پیدا نشد",
                    Data = null,
                };
            }

            var data = new ContactDetailDto
            {
                Company = contact.Company,
                CreationDate = contact.CreationDate,
                Description = contact.Description,
                Id = contact.Id,
                LastName = contact.LastName,
                Name = contact.Name,
                PhoneNumber = contact.PhoneNumber
            };

            return new ResultDto<ContactDetailDto>
            {
                Data = data,
                IsSuccess = true,
            };
        }

        public ResultDto AddNewContact(AddNewContactDto newContact)
        {

            if (string.IsNullOrEmpty(newContact.PhoneNumber))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره موبایل اجباری می باشد. لطفا شماره موبایل هم وارد کنید"
                };
            }


            Contact contact = new Contact()
            {
                Company = newContact.Company,
                CreationDate = DateTime.Now,
                Description = newContact.Description,
                LastName = newContact.LastName,
                Name = newContact.Name,
                PhoneNumber = newContact.PhoneNumber,
            };

            context.Contacts.Add(contact);
            context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = $" مخاطب {contact.Name} {contact.LastName} با موفقیت در دیتابیس ذخیره شد",
            };
        }

        public ResultDto EditContact(EditContactDto editContactDto)
        {
            var contact = context.Contacts.Find(editContactDto.Id);
            if (contact == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "مخاطب پیدا نشد"
                };
            }

            contact.Company = editContactDto.Company;
            contact.Name = editContactDto.Name;
            contact.LastName = editContactDto.LastName;
            contact.Description = editContactDto.Description;
            contact.PhoneNumber = editContactDto.PhoneNumber;

            context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "اطلاعات مخاطب با موفقیت ویرایش شد",
            };

        }
    }
}
