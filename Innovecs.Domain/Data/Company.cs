using System;
using System.Collections.Generic;

namespace Innovecs.Domain.Data
{
    public static class Company
    {
        public static List<Model.Company> Get()
        {
            return new List<Model.Company>()
            {
                new Model.Company()
                {
                    Amount = 10,
                    Cartons = new List<Model.Carton>()
                    {
                        new Model.Carton()
                        {
                            Id = 1,
                            Name = "Carton1",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 10,
                                 Width = 11,
                                 Length = 12
                            }
                        },
                        new Model.Carton()
                        {
                            Id = 2,
                            Name = "Carton2",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 9,
                                 Width = 5,
                                 Length = 2
                            }
                        },
                        new Model.Carton()
                        {
                            Id = 3,
                            Name = "Carton3",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 19,
                                 Width = 23,
                                 Length = 32
                            }
                        }
                    },
                    Consignee = "Mario",
                    Consignor = "Alejandro",
                    ContactAddress = "Address1",
                    DestinationAddress = "Destination1",
                    Packages = new List<Model.Package>()
                    {
                        new Model.Package()
                        {
                            Id = 1,
                            Name = "Package1",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 10,
                                 Width = 11,
                                 Length = 12
                            }
                        },
                        new Model.Package()
                        {
                            Id = 2,
                            Name = "Package2",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 12,
                                 Width = 9,
                                 Length = 2
                            }
                        },
                        new Model.Package()
                        {
                            Id = 3,
                            Name = "Package3",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 9,
                                 Width = 5,
                                 Length = 9
                            }
                        },
                    },
                    Price = 15000,
                    SourceAddress = "SourceAddress1",
                    WareHouseAddress = "WareHouseAddress"
                },
                new Model.Company()
                {
                    Amount = 15,
                    Cartons = new List<Model.Carton>()
                    {
                        new Model.Carton()
                        {
                            Id = 4,
                            Name = "Carton4",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 8,
                                 Width = 9,
                                 Length = 10
                            }
                        },
                        new Model.Carton()
                        {
                            Id = 2,
                            Name = "Carton2",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 9,
                                 Width = 5,
                                 Length = 2
                            }
                        },
                        new Model.Carton()
                        {
                            Id = 5,
                            Name = "Carton5",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 11,
                                 Width = 9,
                                 Length = 10
                            }
                        }
                    },
                    Consignee = "Alejandro",
                    Consignor = "Mario",
                    ContactAddress = "Address2",
                    DestinationAddress = "Destination2",
                    Packages = new List<Model.Package>()
                    {
                        new Model.Package()
                        {
                            Id = 1,
                            Name = "Package1",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 10,
                                 Width = 11,
                                 Length = 12
                            }
                        },
                        new Model.Package()
                        {
                            Id = 4,
                            Name = "Package4",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 9,
                                 Width = 10,
                                 Length = 11
                            }
                        },
                        new Model.Package()
                        {
                            Id = 5,
                            Name = "Package5",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 10,
                                 Width = 11,
                                 Length = 12
                            }
                        },
                    },
                    Price = 25000,
                    SourceAddress = "SourceAddress2",
                    WareHouseAddress = "WareHouseAddress2"
                },
                new Model.Company()
                {
                    Amount = 3,
                    Cartons = new List<Model.Carton>()
                    {
                        new Model.Carton()
                        {
                            Id = 4,
                            Name = "Carton4",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 8,
                                 Width = 9,
                                 Length = 10
                            }
                        },
                        new Model.Carton()
                        {
                            Id = 6,
                            Name = "Carton6",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 9,
                                 Width = 5,
                                 Length = 2
                            }
                        },
                        new Model.Carton()
                        {
                            Id = 7,
                            Name = "Carton7",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 11,
                                 Width = 9,
                                 Length = 10
                            }
                        }
                    },
                    Consignee = "Maria",
                    Consignor = "Andrea",
                    ContactAddress = "Address3",
                    DestinationAddress = "Destination3",
                    Packages = new List<Model.Package>()
                    {
                        new Model.Package()
                        {
                            Id = 1,
                            Name = "Package1",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 10,
                                 Width = 11,
                                 Length = 12
                            }
                        },
                        new Model.Package()
                        {
                            Id = 6,
                            Name = "Package6",
                            Dimension = new Model.Dimension()
                            {
                                 Height = 2,
                                 Width = 2,
                                 Length = 2
                            }
                        },
                    },
                    Price = 35000,
                    SourceAddress = "SourceAddress3",
                    WareHouseAddress = "WareHouseAddress3"
                }
            };
        }
    }
}

