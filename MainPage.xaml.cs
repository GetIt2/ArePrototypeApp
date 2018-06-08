using System;
using Xamarin.Forms;

namespace ArePrototypeGUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoginPage();

        }

        public void LoginPage()
        {
            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                   new Label
                    {
                        Text = "Are's Super App",
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontSize = 40
                    },
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Entry
                            {
                                VerticalOptions = LayoutOptions.Center,
                                Placeholder = "Username",
                            },
                            new Entry
                            {
                                VerticalOptions = LayoutOptions.Center,
                                Placeholder = "Password",
                                IsPassword = true,
                            },
                            new Button
                            {
                                Text = "Log in",
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Command = new Command(ViewMainPage)
                            },
                            new StackLayout()
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Button
                                    {
                                        Text = "Forgot Password",
                                        Command = new Command(ForgotPasswordPage),
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                    },
                                    new Button
                                    {
                                        Text = "New user",
                                        Command = new Command(RegisterNewUser),
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                    }
                                }
                            },
                        }
                    }
                }
            };
        }

        public void RegisterNewUser()
        {
            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                    new Label
                    {
                        FontSize = 30,
                        Text = "Register new user",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Entry
                            {
                                Placeholder = "E-mail",
                                Keyboard = Keyboard.Email
                                },
                            new Entry
                            {
                                Placeholder = "Password",
                                IsPassword = true
                            },
                            new Entry
                            {
                                Placeholder = "Confirm password",
                                IsPassword = true,
                            },
                            new Entry
                            {
                                Placeholder = "Phone number",
                                Keyboard = Keyboard.Telephone
                            },
                            new Button
                            {
                                Text = "Finish registration"
                            }
                        }
                    },
                    new Button
                    {
                        Text = "AlphaBack",
                        HorizontalOptions = LayoutOptions.End,
                        Command = new Command(LoginPage),
                    }
                }
            };
        }

        public void ForgotPasswordPage()
        {
            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                    new Label
                    {
                        Text = "Forgot password",
                        FontSize = 30,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center
                    },
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Entry
                            {
                                Placeholder = "E-mail"
                            },
                            new Button
                            {
                                Text = "Send",
                                HorizontalOptions = LayoutOptions.FillAndExpand
                            }
                        }
                    },
                    new Button
                    {
                        Text = "AlphaBack",
                        HorizontalOptions = LayoutOptions.End,
                        Command = new Command(LoginPage),
                    }
                }
            };
        }

        public void ViewMainPage()
        {

            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                        {
                            new Label
                            {
                                Text = "Credits",
                                FontSize = 30,
                                HorizontalOptions = LayoutOptions.Center,
                                VerticalOptions = LayoutOptions.End,
                            },
                            new Frame
                            {
                                BackgroundColor = Color.Gray,
                                VerticalOptions = LayoutOptions.StartAndExpand,
                                HorizontalOptions = LayoutOptions.Center,
                                Content =
                                    new Label
                                    {
                                        Text = "69",
                                        VerticalOptions = LayoutOptions.StartAndExpand,
                                        HorizontalOptions = LayoutOptions.Center,
                                        FontSize = 80
                                    }
                            },
                            new Button
                            {
                                Text = "Start Charging",
                                HorizontalOptions = LayoutOptions.Center,
                            }
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.End,
                        Children =
                        {
                            new Button
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Text = "Main",
                                BackgroundColor = Color.Red,
                                Command = new Command(ViewMainPage)
                            },
                            new Button
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Text = "Store",
                                Command = new Command(StorePage)
                            },                            new Button
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Text = "Account",
                                Command = new Command(AccountPage)
                            },
                        }
                    }

                }
            };
        }

        private void StorePage()
        {
            Content = new StackLayout
            {
                Margin = 20,
                Children =
                {
                    new Label
                    {
                        Text = "Store",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        FontSize = 30,
                    },
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.StartAndExpand,
                        Children =
                        {
                            new Button
                            {
                                Text = "Payment Option 1"
                            },
                            new Button
                            {
                                Text = "Payment Option 2"
                            },
                            new Button
                            {
                                Text = "Payment Option 3"
                            },
                            new Button
                            {
                                Text = "Payment Option 4"
                            },
                            new Button
                            {
                                Text = "Payment Option 5"
                            },
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new Button
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Text = "Main",
                                Command = new Command(ViewMainPage),
                            },
                            new Button
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Text = "Store",
                                Command = new Command(StorePage),
                                BackgroundColor = Color.Red
                            },
                            new Button
                            {
                                HorizontalOptions = LayoutOptions.FillAndExpand,
                                Text = "Account",
                                Command = new Command(AccountPage)
                            }
                        }
                    }
                }
            };
        }

        private void AccountPage()
        {
          Content = new StackLayout
          {
              Margin = 20,
              Children =
              {
                  new Label
                  {
                      Text = "Account page",
                      FontSize = 30,
                      HorizontalOptions = LayoutOptions.Center,
                      VerticalOptions = LayoutOptions.CenterAndExpand
                  },
                  new StackLayout
                  {
                      VerticalOptions = LayoutOptions.StartAndExpand,
                      Children =
                      {
                          new Label
                          {
                              Text = "E-Mail: somthing@getacademy.no",
                              HorizontalOptions = LayoutOptions.Center,
                              FontSize = 15
                          },
                          new Label
                          {
                              Text = "Phone: 98765432",
                              HorizontalOptions = LayoutOptions.Center,
                              FontSize = 15
                          },
                          new Button
                          {
                              Text = "Change E-mail/Phone Number",
                          },
                          new Button
                          {
                              Text = "Change Password",
                          },
                          new Button
                          {
                              Text = "Statistics",
                          },
                          new Button
                          {
                              Text = "Log Out",
                              BackgroundColor = Color.DarkRed,
                              Command = new Command(LoginPage)
                          }
                      }
                  },
                  new StackLayout
                  {
                      Orientation = StackOrientation.Horizontal,
                      Children =
                      {
                          new Button
                          {
                              HorizontalOptions = LayoutOptions.FillAndExpand,
                              Text = "Main",
                              Command = new Command(ViewMainPage)
                          },
                          new Button
                          {
                              HorizontalOptions = LayoutOptions.FillAndExpand,
                              Text = "Store",
                              Command = new Command(StorePage)
                          },
                          new Button
                          {
                              HorizontalOptions = LayoutOptions.FillAndExpand,
                              Text = "Account",
                              Command = new Command(AccountPage),
                              BackgroundColor = Color.Red
                          }
                      }
                  }
              }
          };  
        }
    }
}




