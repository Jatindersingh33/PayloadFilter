using System;
using Xunit;
using PayloadFilter.Models;
using PayloadFilter.ViewModels;
using System.Collections.Generic;

namespace PayloadFilter.Tests
{
    public class PayloadRepositoryTests
    {
        private PayloadRepository _payloadRepo;
        public PayloadRepositoryTests()
        {
            _payloadRepo = new PayloadRepository();
        }


        [Fact]
        public void GetFilteredPayload_Expected_EligiblePayload()
        {
            //Arrange   
            var expectedResult = new List<PayloadViewModel>()
            {
              new PayloadViewModel()
                {
                  Image = "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg",
                  Slug="Slug Test",
                  Title="The Taste India"
                }
            };

            //Act
            var actualResult = (List<PayloadViewModel>)_payloadRepo
                                .GetFilteredPayload(ArrangeMockPayload());

            //Assert
            Assert.Equal(expectedResult[0].Image, actualResult[0].Image);
            Assert.Equal(expectedResult[0].Slug, actualResult[0].Slug);
            Assert.Equal(expectedResult[0].Title, actualResult[0].Title);
        }

        public Payloads ArrangeMockPayload()
        {
            var payloads = new Payloads()
            {
                Payload =
                   new List<Payload>(){
                    new Payload()
                        {
                            Country = "US",
                            Description = "What's life like when you have enough children to field your own football team?",
                            Drm = false,
                            EpisodeCount = 2,
                            Image = new Image() { ShowImage = "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg" },
                            Language = "English",
                            NextEpisode = null,
                            PrimaryColour = "#ff7800",
                            Seasons = new List<Season>() { new Season { Slug = "show/16kidsandcounting/season/1" } },
                            Slug = "",
                            Title = "The Taste",
                            TvChannel = "Channel 9"
                        }
                    ,
                    new Payload()
                        {
                            Country = "UK",
                            Description = "Description",
                            Drm = true,
                            EpisodeCount = 0,
                            Image = new Image() { ShowImage = "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg" },
                            Language = "French",
                            NextEpisode = null,
                            PrimaryColour = "#ff780d0",
                            Seasons = new List<Season>() { new Season { Slug = "show/16kidsandcounting/season/1" } },
                            Slug = "",
                            Title = "The Taste Australia",
                            TvChannel = "Channel 7"
                        }
                    ,
                    new Payload()
                        {
                            Country = "India",
                            Description = "Description",
                            Drm = true,
                            EpisodeCount = 2,
                            Image = new Image() { ShowImage = "http://mybeautifulcatchupservice.com/img/shows/16KidsandCounting1280.jpg" },
                            Language = "English",
                            NextEpisode = null,
                            PrimaryColour = "#ff780d0",
                            Seasons = new List<Season>() { new Season { Slug = "show/16kidsandcounting/season/1" } },
                            Slug = "Slug Test",
                            Title = "The Taste India",
                            TvChannel = "Channel Ind"
                        }
                   }
            };
            return payloads;
        }
    }
}
