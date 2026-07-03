# 3329962


## Table of Contents

- [Part 1: Let's Get Started!](#part-1-lets-get-started)
  - [1. Introduction to the Course](#1-introduction-to-the-course)
  - [2. What Is Cloud Computing and AWS？](#2-what-is-cloud-computing-and-aws)
  - [4. AWS Account Overview](#4-aws-account-overview)
  - [7. [HOL] Install Tools and AWS CLI](#7-hol-install-tools-and-aws-cli)
- [Part 2: Amazon Web Services Fundamentals](#part-2-amazon-web-services-fundamentals)
  - [8. Introduction](#8-introduction)
  - [9. The AWS Global Infrastructure](#9-the-aws-global-infrastructure)
  - [10. The AWS Shared Responsibility Model](#10-the-aws-shared-responsibility-model)
  - [11. Application Programming Interfaces (APIs)](#11-application-programming-interfaces-apis)
  - [12. AWS Pricing Fundamentals](#12-aws-pricing-fundamentals)
  - [13. The 6 Advantages of Cloud Computing](#13-the-6-advantages-of-cloud-computing)
- [Part 3: AWS Authentication and Access Control](#part-3-aws-authentication-and-access-control)
  - [14. Introduction](#14-introduction)
  - [15. AWS Identity and Access Management (IAM)](#15-aws-identity-and-access-management-iam)
  - [16. [HOL] Creating IAM Users and Groups](#16-hol-creating-iam-users-and-groups)
  - [18. [HOL] Switching IAM Roles](#18-hol-switching-iam-roles)
  - [19. IAM Identity Center](#19-iam-identity-center)
- [Part 4: Amazon EC2, Auto Scaling, and Load Balancing](#part-4-amazon-ec2-auto-scaling-and-load-balancing)
  - [21. Introduction](#21-introduction)
  - [22. Server Virtualization](#22-server-virtualization)
  - [23. Scaling Up vs Scaling Out](#23-scaling-up-vs-scaling-out)
  - [24. High Availability and Fault Tolerance](#24-high-availability-and-fault-tolerance)
  - [26. [HOL] Launching Amazon EC2 Instances](#26-hol-launching-amazon-ec2-instances)
  - [27. [HOL] Connecting to Amazon EC2](#27-hol-connecting-to-amazon-ec2)
  - [28. Access Keys and IAM Roles with EC2](#28-access-keys-and-iam-roles-with-ec2)
  - [29. [HOL] Practice with Access Keys and IAM Roles](#29-hol-practice-with-access-keys-and-iam-roles)
  - [31. Amazon EC2 Auto Scaling](#31-amazon-ec2-auto-scaling)
  - [33. Amazon Elastic Load Balancing](#33-amazon-elastic-load-balancing)
  - [34. [HOL] Create an Application Load Balancer](#34-hol-create-an-application-load-balancer)
  - [35. [HOL] Create a Scaling Policy](#35-hol-create-a-scaling-policy)
- [Part 5: Amazon Virtual Private Cloud (VPC)](#part-5-amazon-virtual-private-cloud-vpc)
  - [36. Introduction](#36-introduction)
  - [38. Routers, Switches and Firewalls](#38-routers-switches-and-firewalls)
  - [39. IP Addressing](#39-ip-addressing)
  - [40. Amazon Virtual Private Cloud (VPC)](#40-amazon-virtual-private-cloud-vpc)
  - [41. [HOL] Create a Custom VPC](#41-hol-create-a-custom-vpc)
  - [42. Security Groups and Network ACLs](#42-security-groups-and-network-acls)
  - [43. [HOL] Using Security Groups and NACLs](#43-hol-using-security-groups-and-nacls)
  - [44. Cloud Computing Deployment Models](#44-cloud-computing-deployment-models)
  - [45. AWS VPN and AWS Direct Connect](#45-aws-vpn-and-aws-direct-connect)
- [Part 6: AWS Storage Services](#part-6-aws-storage-services)
  - [46. Introduction](#46-introduction)
  - [47. Block vs File vs Object Storage](#47-block-vs-file-vs-object-storage)
  - [48. Amazon EBS and Instance Stores](#48-amazon-ebs-and-instance-stores)
  - [49. [HOL] Create and Attach an EBS Volume](#49-hol-create-and-attach-an-ebs-volume)
  - [51. Amazon Elastic File System (EFS)](#51-amazon-elastic-file-system-efs)
  - [53. Amazon Simple Storage Service (S3)](#53-amazon-simple-storage-service-s3)
  - [54. [HOL] Working with S3 Buckets and Objects](#54-hol-working-with-s3-buckets-and-objects)
  - [55. [HOL] Create an Amazon S3 Static Website](#55-hol-create-an-amazon-s3-static-website)
- [Part 7: AWS Database Services](#part-7-aws-database-services)
  - [56. Introduction](#56-introduction)
  - [57. Database Types and Use Cases](#57-database-types-and-use-cases)
  - [59. [HOL] Create an Amazon RDS Database](#59-hol-create-an-amazon-rds-database)
  - [60. Amazon DynamoDB](#60-amazon-dynamodb)
  - [61. [HOL] Create an Amazon DynamoDB Table](#61-hol-create-an-amazon-dynamodb-table)
- [Part 8: Automation and DevOps on AWS](#part-8-automation-and-devops-on-aws)
  - [62. Introduction](#62-introduction)
  - [63. Infrastructure as Code with AWS CloudFormation](#63-infrastructure-as-code-with-aws-cloudformation)
  - [64. [HOL] Creating and Updating Stacks](#64-hol-creating-and-updating-stacks)
  - [65. [HOL] Deploy a VPC Using CloudFormation](#65-hol-deploy-a-vpc-using-cloudformation)
  - [66. Platform as a Service with AWS Elastic Beanstalk](#66-platform-as-a-service-with-aws-elastic-beanstalk)
  - [67. [HOL] Create an Elastic Beanstalk Application](#67-hol-create-an-elastic-beanstalk-application)
  - [68. Continuous Integration and Continuous Delivery (CI⧸CD)](#68-continuous-integration-and-continuous-delivery-cicd)
  - [69. [HOL] AWS CodePipeline with AWS Elastic Beanstalk](#69-hol-aws-codepipeline-with-aws-elastic-beanstalk)
- [Part 9: DNS, Caching, and Performance Optimization](#part-9-dns-caching-and-performance-optimization)
  - [70. Introduction](#70-introduction)
  - [71. Bandwidth and Latency](#71-bandwidth-and-latency)
  - [72. DNS and Amazon Route 53](#72-dns-and-amazon-route-53)
  - [73. [HOL] Register a Domain Using Route 53 (optional)](#73-hol-register-a-domain-using-route-53-optional)
  - [74. Amazon CloudFront](#74-amazon-cloudfront)
  - [75. [HOL] Create a Secure CloudFront Distribution](#75-hol-create-a-secure-cloudfront-distribution)
  - [76. AWS Global Accelerator](#76-aws-global-accelerator)
- [Part 10: Containers and Serverless Computing](#part-10-containers-and-serverless-computing)
  - [77. Introduction](#77-introduction)
  - [78. Docker Containers and Microservices](#78-docker-containers-and-microservices)
  - [79. Amazon Elastic Container Service (ECS)](#79-amazon-elastic-container-service-ecs)
  - [80. [HOL] Launch Docker Containers on AWS Fargate](#80-hol-launch-docker-containers-on-aws-fargate)
  - [81. Serverless Services and Event-Driven Architecture](#81-serverless-services-and-event-driven-architecture)
  - [82. AWS Lambda](#82-aws-lambda)
  - [83. [HOL] Working with AWS Lambda](#83-hol-working-with-aws-lambda)
  - [84. Application Integration Services](#84-application-integration-services)
  - [85. [HOL] Serverless Application with REST API – Part 1](#85-hol-serverless-application-with-rest-api-part-1)
  - [86. Amazon API Gateway](#86-amazon-api-gateway)
  - [87. [HOL] Serverless Application with REST API – Part 2](#87-hol-serverless-application-with-rest-api-part-2)
  - [88. Amazon EventBridge](#88-amazon-eventbridge)
- [Part 11: Machine Learning and AI](#part-11-machine-learning-and-ai)
  - [89. Introduction](#89-introduction)
  - [90. Using Generative AI as a Learner](#90-using-generative-ai-as-a-learner)
  - [91. [HOL] Creating Projects and Code with ChatGPT](#91-hol-creating-projects-and-code-with-chatgpt)
  - [92. AWS Machine Learning and AI Services](#92-aws-machine-learning-and-ai-services)
  - [93. [HOL] Process and Analyze Videos](#93-hol-process-and-analyze-videos)
- [Part 12: Get Certified on AWS](#part-12-get-certified-on-aws)
  - [94. Introduction](#94-introduction)
  - [95. Get Certified on AWS](#95-get-certified-on-aws)


---

## Part 1: Let's Get Started!


### 1. Introduction to the Course

Hello and welcome to the introduction to cloud computing on Aws course. In this course, I'm gonna teach you cloud computing right from the beginning, you're gonna learn about the fundamentals of cloud computing, what it is, how it's constructed and what benefits it offers to businesses around the world. And then I'm gonna start teaching you about Amazon web services Aws. And we're gonna go right from the beginning with some very simple concepts through to some fairly advanced technology with server and event driven applications.

So you will actually learn how to build on Aws. It's not just theory all the way through the course, you're gonna be learning how to actually implement what I'm teaching you. So I'm gonna start with some simple exercises and then work through to to some fairly advanced scenarios later on in the course. The best way to use this course is to simply start from the beginning and work your way through.

I do use space repetition and I do use multiple modalities of learning. So you'll find animated visual diagrams to help you understand the concepts and visualize what we're going to build and how things integrate together. I use practical exercises to make sure that you're able to implement what you're learning. So, start from the beginning, work your way through and you'll build up your skills over time.

At the end of this section, you'll find a lesson called course download, make sure you follow the link to download the code that you're going to need to work through the lessons in this course. You also need to set up a free tier account on Aws. And I'm gonna show you how to do that right in this very first section. So that's it from me for now.

I hope you enjoy the course and I'll see you in the next lesson.


### 2. What Is Cloud Computing and AWS？

Hello and welcome to this lesson in this lesson. I'm going to cover some of the fundamentals of cloud computing and what the benefits of cloud computing are. And then I'm gonna go into Amazon web services, Aws giving you a high level overview of the AWS cloud and some of the features and pricing models and how we can actually manage services in Aws. I'm gonna start off by comparing some of the traditional non cloud services that you might be familiar with to their counterparts in the cloud.

So for example, here we have an email server. So back in the day and some companies still do this, but back in the day, many companies I worked with would have their own email server. So I would often be the one setting up their email servers and you had to deploy a lot of infrastructure in different parts of the world. If it was a global organization set up all the mail routing, it was quite a job.

Many companies today choose instead to utilize a cloud service like gmail or Microsoft office 365 then we've got file servers. Of course, many companies still use file services today. There's lots of use cases for that, but there are counterparts in the cloud like Dropbox, for example, and of course Gmail with G drive, they have their own as well as do Microsoft and many other big companies. And then we've got customer relationship management systems.

These are certainly less popular on premises these days because most companies prefer to use a cloud based service like salesforce.com instead. Now some of the characteristics of the cloud services are firstly, you don't own or manage the infrastructure on which the service runs now that can significantly reduce the capital expenditure. Because this infrastructure, these servers, the networking, the storage systems, all of the different components that it takes to deliver. These types of services on premises do cost a lot of money.

That's a lot of capital, a lot of cash that the company might not want to give away. And then of course, there's all that maintenance and management that you have to do. Also cloud services are usually on a subscription or consumption model. Again, moving away from that capital expenditure, large amounts of cash and instead spending money on a monthly basis based on either a fixed subscription rate or consumption.

So actually how much you use that month also services in the cloud will typically scale automatically as demand changes. So if you have a big spike in traffic, then the cloud service should scale automatically along with that demand. And of course, you'll pay appropriately for the extra services that you used. Now, there are various different types of cloud, but they all should share the same key characteristics and I'll just cover these off very quickly.

So firstly, they should be on demand and self-service. That means there should be a capability where users of the cloud, the consumers of the cloud are able to go into some kind of self service portal or catalog and actually choose which services they want to use. And those services should then be delivered automatically without any human intervention at all, we then have broad network access. So most cloud services will be accessible over the internet using standard protocols that we're used to like for example, http.

So in some cases, you might be connected to a cloud using private networks, that's OK, either a VPN or a private connection. But at the same time, usually most of the public cloud services or the hyperscale providers, for example, they all provide public access to their API. So we'll talk more about that later. Next up, you have resource pooling.

All this means is that the cloud service provider have aggregated a large capacity of compute storage networking, all of the underlying infrastructure that is required to deliver the cloud service and then they allow multiple tenants. In other words, the customers to utilize that infrastructure with security isolation between them. Of course, the next characteristic is rapid elasticity. So as I mentioned before, most cloud services should scale automatically based on demand.

So as you get more demand for your application, the underlying infrastructure is gonna scale so that your service has more resources to use. And then when you don't need those resources, they're gonna be given back again. And that brings us to the last point, the measured service because you should only be paying for what you actually use. And that of course means that there should be some kind of itemized bill where you can see the various different components of your bill, how much you used, what the rate for that service was and then your total amount.

So those are the key characteristics. Now you can build your own cloud. And if it has all of these characteristics, then that's what we would call a private cloud. So in other words, you might build this in your data center.

I've built lots of these for customers. I can tell you it's very complex and very expensive, but occasionally there are use cases where this is beneficial to a company. So here we have a virtualization cluster, we have storage and backup systems. We've got network and firewall systems.

But then on top of that, we have to add on those capabilities. So we need the self service, we need the service catalog, we need the service automation, we need orchestration. So everything is automated in terms of the delivery of the service monitoring and logging. So we know what's going on billing and reporting so that we can charge the customers multi tenancy so that we can have multiple customers.

And if you're within a company building, a private cloud, those customers might not be other companies, they could be different companies within a group of companies, or they could be just simply be different business units within your company. And then we've got other things like configuration management, life cycle management, security and identity, and so on. Now, of course, all of this comes with quite a significant cost. We've got the data center itself, you've got the security services, you've got power, you've got connectivity, you've got physical hardware, software licensing and maintenance contracts.

And then of course, you've got staff costs lots of operations and management. So building a private cloud is quite an expensive exercise and often you still don't get the capabilities that you might get from a public provider like AWS. So what is the public cloud? So the public cloud and of course, an example here is Amazon web services, but there are others like Microsoft Azure and Google cloud platform as well.

But it's basically a cloud that is accessible to the public. So you as an individual or your company can come along with a credit card, set up an account and start utilizing those cloud services. Now, if you're a company, you will typically have some kind of office or maybe a data sensor. If you've got your own systems and you can then connect to that public cloud, either just directly over the internet or you can set up a private connection or a VPN over the internet.

And then you can start deploying services like compute storage network and databases in the cloud. And there's many, many more different types of service on Aws. So the benefits of this model, you have a variable expense instead of a capital expense. So you're paying on a monthly basis for what you use.

There are exceptions to that. Aws does have some larger discounts if you lock in for a year or three years. But other than that, most services are available on a monthly expenditure where you're just paying for what you use, you've got economies of scale. So Aws are huge, they've got hundreds of thousands of customers all over the world.

They invest very heavily both in their platforms and in the software that sits on top of it, all of those services that they build. So that provides economies of scale, which means they can reduce the cost of those services to you as the end consumer and you get massive elasticity. Aws are huge. They have such a massive amount of compute power that it's very rare that they're gonna run out.

There's usually always some capacity somewhere. And so even the biggest companies with the largest requirements don't have an issue scaling in the cloud. And as I mentioned, other examples would be Microsoft, Azure and Google cloud platform as well. AWS is by far the leader in this space.

Azure come in second place, a Google cloud platform a little way behind that. Now, there's a few different service models in the cloud. The first one is private cloud. We just had a look at that.

That's where you build it yourself. Now, if you build it yourself, not only do you have that big capital expenditure, but of course, you have to manage it all the responsibility is on you. Then we have what we call infrastructure as a service or IAS this is where essentially you have managed virtual machines. So if you understand virtualization, essentially, it just means that you have virtual uh servers running an operating system like Linux or Windows and everything underneath that operating system is managed for you.

Then we've got platform as a service, which is another level up, it means less overhead for you in terms of management. Now you just bring your code and lastly software as a service. So here everything is managed for you, you know, going back to salesforce.com or email services like gmail. That's a Sass service because everything is managed for you.

You have very limited scope though, in terms of what you can do to modify the platform. So let's look at these side by side, on the left hand side here, you've got the private cloud. So here everything is managed for you. We saw before that there's lots of software layers which I'm not showing on this screen as well.

So you have to manage everything with infrastructure as a service. You can see here the the server layer including all the associated storage and networking and the hypervisor are managed for you. So now you have these virtual machines, these V MS just sitting on top in the cloud, we also call them instances. So what you have to manage if you're using I A is the operating system.

So Windows or Linux and you have to manage all the updates, for example, the software updates, uh then any application frameworks that you're using and then your data, of course, and then your application itself, if you go to platform as a service, you lose some of that responsibility. So you give it away, you outsource it to someone else. So now all you're doing is bringing your data and your code for your application, everything underneath it is managed. And then lastly, of course, we have that SAS service where you basically don't have much responsibility, but also it means you have less control, you're losing control as you give this away, moving from where you have that, you know, larger expense and larger complexity on the private cloud.

On the left hand side, through to a SAS service on the right where you no longer have to worry about a lot of stuff. But of course, you have less scope to modify it or customize it to your own requirements. Ok. So let's work at Amazon Web services, Aws.

So they are what's known as a hyperscale public cloud provider. They've got well over 200 services. I don't give exact numbers cos it changes all the time. Uh Occasionally they decommission a service usually with a good bit of notification, usually about a year or so, but mostly it's just about increasing that number because they're constantly adding new services all the time in terms of market leadership and growth.

They are the leading cloud service provider with by far the largest market share and they have global infrastructure. So that means they've got data centers and infrastructure equipment within those data centers all over the world. And we'll look a bit more into detail on that in a moment in terms of innovation and expansion, Aws is known for rapid pace of innovation. It's hard to keep up sometimes because they are constantly innovating, changing things, improving them and releasing new services.

So let's have a look at the global infrastructure at a high level. So around the world, Aws has regions and these are essentially separate physical locations in the world. There are many of them around the world. Again, the number increases all the time.

So I'm not gonna give you an exact number. So you can see here. We've got us East, we've got Eu West and we've got A P Southeast. Now, each region consists of multiple availability zones.

You can see in the diagram here we have free availability zones in each region. Now, some regions will have more than that. An availability zone is essentially one or more separate data centers. OK.

So it's at least one separate data center. So for most purposes, I just consider each availability zone to be a data center, but it could be more than one data centers. And AWS don't tell us that they don't release that level of information. All of these regions are connected with a network known as the AWS global network.

And that's a highly redundant network with very good bandwidth and low latency. So how do we go and manage AWS services? There's a few different ways we're gonna look at those. Now, the first one is the management console.

This is a graphical user interface access via a web browser. And from there, we can find many services. You can see some examples here. On the left hand side, these are just the categories of service.

And then on the right hand side, we're just seeing a snippet of the ones that start with the letter A. There's obviously a lot of services here. The next option we have if we don't want to use the graphical user interface is the command line with a cli we can run simple commands like this one to launch a virtual server in the cloud or this one here will list the contents of a storage container that's called a bucket on the Amazon S free service. The cli is a utility that you can install on your computer, whether you're on Windows, Linux or Mac, you can also run CLI commands in the cloud on Aws as well using a service called aws Cloudshell.

Lastly, we have programmatic management here. We're using a software development kit and there are several different software development kits for different programming languages. For example, we got bore for Python. So a developer will write code in an integrated development environment, an ID E or some similar tool.

And then you can package that code and that code is able to speak to the API on AWS. So basically anything that you want to do in the cloud, you can do either through the management console, the command line interface or if you're a developer, you can leverage one of the software development kits. So you can see we have a huge amount of power here and we can perform this management using one of these different methods from anywhere in the world over the internet. OK.

So that's it for this lesson. Just a brief overview of cloud computing in Aws. And we're gonna get into a lot more detail in subsequent lessons.


### 4. AWS Account Overview

Welcome back in this video. I'm going to give you a brief overview of what Aws accounts are, how we create them and how we manage them. And then in the next lesson, I'm gonna show you how to create your own free tour account on Aws. So to get started, what do you need to open an Aws account?

First thing is you will need a credit card. Secondly, you're going to need a unique email address and by unique, I mean, it cannot be associated with any other Aws account. Now you can create multiple Aws accounts but you will need a different email address for them. But the credit card can be the same.

I often use dynamic email aliases. So if your email address was John at gmail.com, you can do John plus Aws account one at gmail.com and then Aws account two at gmail.com and so on. That's a dynamic email alias. It works with Gmail, it works with some other mail services as well.

So once you've got these two things, you can create an Aws account. Now, when you do so it's gonna create something called the account root user. Now the account root user logs in with the email address that you created the account with. So there's gonna be an email address and a password.

Now, the root user has full control over the account. You also cannot limit most of the permissions associated with the root user. For that reason. It's an all powerful account and we don't want to use it.

The best practice is to set a very strong password and then not use the root user account unless you specifically need to. What we do instead is we use the identity and access management service. I am with I am we can create users, groups, roles and policies. So what we do is we create a user account, we then create a group to put the user into and then we associate a policy that has permissions to that group.

You'll see how to do this in another lesson that user can have uh a user name, like your own name. I use Neil, of course. And so that is the user that you are then going to use subsequently to log in to Aws. So it's very important to remember that it is an I am best practice to create individual users and to avoid using the root account unless you specifically need to.

And there are a few cases where the root account is required. So we have our aws account, we can log in through the management console. That's gonna be the easiest way to get started. And from there, what we need to do is authenticate.

So when we log in with an I AM principle, like a user account, we essentially have to authenticate. And of course, we have these different methods of accessing AWS and managing it. We can use the console. We can also use the command line interface.

Or if we're developing code, we can leverage the API through a software development kit, but we always need to authenticate prove who that we are. Who we say we are. For example, with a user name and password. If you're logging into the management console, then we get authorized to access certain resources.

And this is defined through policies. The policies define what resources we're allowed to access and what level of access we have. For example, we might have access to EC2 instances, R DS, databases, S free and low balances. Now, all identities and resources are created within the AWS account.

There are ways that you can have multiple account structures where you can centralize some of the management, but each of the users will exist in one place and then you have to implement measures to access resources across a different accounts. So that's it for this lesson. We're gonna go ahead in the next lesson and create our free to account and make sure you've got a unique email address and a credit card ready.


### 7. [HOL] Install Tools and AWS CLI

Hey guys, a very quick lesson. Just to advise you on some of the tools that you're going to need to install as well as the AWS command line interface. First thing you need to do is make sure that before you finish this section of the course, the very last lesson of this section has some code. What you need to do is when you go to that lesson, you will find a link that will take you over to a github page.

And from there, you can download the code if you're a bit more advanced and you know how to use GIT, you can also simply synchronize the repository. The next thing you need to do is install visual studio code. We're going to be using visual studio code so that we can open various different code, snippets and instruction files. So on Google here, I'm simply gonna search for visual studio code.

This is a Microsoft product. It's completely free. And if you find it on the internet, you're going to be able to download it for your operating system and simply install it. So that's all you need to do, whichever operating system you have just choose the relevant download and then install visual studio code.

The next thing you need to do is install the AWS command line interface again on Google. I'm simply going to search for AWS command line interface. And here I want to click on the install or update to the latest version of the AWS CLI. OK.

So we will be able to run command line. This will enable us to run CLI commands from our computers. Now, what you can see here is we've got Linux Mac Os and Windows. So just choose the relevant operating system and follow the instructions to install the package on your computer.

Lastly, we want to check that we can access aws cloudshell. Cloudshell provides a command line interface in the cloud. I prefer using it these days over the AWS CLI on my computer. In most cases, it's also preconfigured with credentials for the command line interface.

After you've installed it, you won't be able to run any aws commands because you haven't authenticated. I'm gonna show you how to configure credentials a bit later on after we've created our individual I am user account, but cloudshell is already authenticated as you as the user you're logged in with. So it's a really easy way of accessing the command line interface in the cloud back in the aws management console. I'm simply gonna search for cloudshell, click on cloudshell.

And what this should do is spin up an environment for us which usually takes up to 30 seconds. Now, I do know that some students have had challenges with getting cloudshell. It's something to do with Aws restricting access to cloudshell for new accounts with new credit cards that they haven't seen before. I've used the same credit card over multiple accounts, so I don't have an issue, but I have known some students to have experienced that problem.

If that's the case, you'll need to contact Aws support and ask them to enable it. If they won't do it initially, then you just have to use the AWS command line interface on your computer, which I will show you how to do the actual aws CLI commands are identical. It doesn't matter whether you're using cloudshell or your own computer. However, of course, your operating system commands are gonna be different.

This is a Linux command line interface here on your computer. You might be using windows. If that's the case, then navigating your file system is gonna be slightly different to what I do in cloudshell. But the actual cli commands will be the same.

Now, we can see that the font's quite small on cloudshell. In the top right hand corner, I can adjust the settings and make it a bit larger. So now you can see more easily if I run aws help, then we should see the help interface for the AWS command line interface and I can use my space bar just to go through and see the various options and type Q to quid out of there. Then I can run commands like AWS S3 LS.

If I had any buckets, any folders in my Amazon S3 service, then I would be able to see them. Now, I don't have any because this a brand new account. However, we can tell by the fact that I didn't receive an error message that I do have credentials to perform that operation. So that's the good thing about cloudshell.

It's preconfigured with credentials for us. So that's it for this video. Make sure you download the code, make sure you install visual studio code, install the command line interface if you want to be able to run the cli on your computer and make sure that you can access cloudshell and you're all set up.


---

## Part 2: Amazon Web Services Fundamentals


### 8. Introduction

Hey guys and welcome to this section of the course in this section. I'm gonna teach you about Amazon web services. I need you to understand what it is before we can start getting into more of the practical elements and deep diving into the different topics and services around Aws. So this section is the only section that doesn't have any hands on lessons.

It's pure theory. So just sit back and listen, take some notes and learn about Amazon web services.


### 9. The AWS Global Infrastructure

Hey guys. Welcome back in this lesson. I'm gonna cover the AWS global infrastructure that is the name that Aws assign to the various infrastructure including the data centers and the availability zones and other equipment that they have all over the world. So let's have a look at how it's composed.

So firstly, we have regions, the regions are separate physical locations around the world. Now there are lots and lots of regions around the world and the list is growing all the time within each of the regions. We have multiple availability zones, usually at least three. Sometimes there's more than that.

For example, us e one, there has six availability zones at the time of this recording. All of those numbers can always change. Now, an availability zone is one or more physical data centers. So just consider it to be a separate data center.

Now that means that you can spread your resources across availability zones and there's less correlation in terms of failure. So if one data center fails for some reason, then the other ones shouldn't. So you can spread your resources and make sure that you always have uh your applications running when you need them. Now, all of the regions are connected around the world by AWS global network.

That's a network that's managed by AWS. They make sure that there's plenty of bandwidth and they manage the latency. So you get great performance when you're moving data between Aws regions. Now, within each region as well, there's lots of networking capability that's always redundant.

Now, what else is there other than regions? So we have regions and availability zones within the availability zones, we create subnets which can be public or private and that's where we launch our resources. There's also other ways that you can leverage Aws services. For example, if you have a corporate data center, you can actually get a piece of hardware that comes into your data center.

It's called Aws outposts. An Aws outpost supports a subset of services available from Aws. So not everything but things like EC2 can be run on premises and it has connectivity, of course, back to an Aws region. Next, we have something called a local zone.

These are a bit like availability zones and they're usually in metropolitan areas. And the idea is that they get your resources just a bit closer to where you are. So if there's a local zone that's closer to your office or your data center than the actual region, data centers themselves, then that can be a good place to launch your resources and you pay a bit more for it. But you get lower latency, then we have wavelength zones.

These are for five G. So if you, for example, have mobile applications and you wanna make those available over the five G network, you can deploy your applications in a wavelength zone. And again, it's about lowering the latency, lowering the delay between the server or the mobile application in this case. And the actual service that's being delivered from the data center.

And again, wavelength zones have connectivity back to the AWS region. So they're about performance, about increasing performance for your applications and connecting them to your end users or to the servers in your data center. Now let's break down a region to give you a bit more detail about the level of redundancy here. So here I'm just showing two availability zones.

There's usually more than that. So each availability zone can then be used to create subnets. OK? A subnet is just an IP networking space.

So you can create public subnets. They have public accessibility. That means your applications like your web servers can be available on the internet or you can create private subnets that have no direct connectivity from the outside world. Now each availability zone has redundant power sources.

So you're not relying on one power source there. If one fails, the other one should pick up the load. We also have redundant networking both within the availability zone and between availability zones. Now availability zones have low latency between them.

So the network performance between availability zones and within them, of course, is very good. And that's because the availability zones are relatively close together. Aws don't specify exactly how close, but they're relatively close within a metropolitan area. On the other hand, the actual regions are fairly distant from each other.

So it makes sense to keep your applications, make them highly available within a region so that you've got great performance and you can fail over very quickly between one availability zone and another. However, if for disaster recovery purposes, you need to have a copy of your applications more geographically distant, then that's where you would put them into a separate region. So now we can deploy our resources across our different subnets within different availability zones. And that's how we get high availability and we'll see how we can then connect to them a bit later on.

Another component of the AWS global infrastructure is Amazon cloudfront cloudfront is a content delivery network. What that simply means is that content, for example, videos or images can be cached at different places around the world. And that means that users in those different places in the world are able to access those resources with lower latency. Again, it's about network performance.

It's about the performance of the application. If you wanna watch a video from Australia, you don't want that video to be physically located in the US cos that's a long way away and the performance won't be good. So cloudfront makes sure that it's cached in different parts of the world so that there should be a copy of that video closer to you. Now with AWS, we can of course very simply deploy services globally, absolute game changer with the cloud.

Here in the past, when I used to have to deploy resources into different data centers in different parts of the world. It was extremely difficult. It was also extremely expensive. Now with the management console, the CLI or the API you can deploy resources all over the world.

For example, here we're launching virtual servers and databases in different parts of the world. And in some cases, you might set them up to be redundant and automatically copying data between them and synchronizing that data very, very easy to set up in the cloud, very difficult to do it outside of the cloud. When you're managing all that infrastructure yourself.


### 10. The AWS Shared Responsibility Model

Hey guys in this lesson, I'm gonna cover a concept known as the Aws shared responsibility model. So this is a graphic straight from Aws. This is a very important concept. You need to understand what it is that you are responsible for and what it is that Aws as the provider of cloud services is responsible for.

And so you can see that delineation here. Now on the top there, we've got the customer that's you as the consumer of the cloud. Of course, at the very, very top there is data data is your problem. That's your data.

It's your responsibility. Now of course, underlying all this for data, we've got storage, we've got databases, you know, we've got connectivity services for transmitting data, Aws are supplying those services and they supply the options for things like encryption and they make sure that your data is durably stored and copied into different places. So you need to understand how they do that and what the levels of durability and availability are. But ultimately, you're responsible for your data.

Now again, platform applications, identity and access management, Aws provide the identity and access management service, but you're responsible for creating users, creating groups, creating roles, creating policies, assigning the correct permissions if you provide too many permissions and somebody does something that they shouldn't. Then unfortunately, that is your responsibility. That does become your problem. Now, underneath that, we've got operating systems.

Now here in some cases, Aws will manage things like the patches of operating systems. So there are some examples of where that's a shared responsibility. But mainly for example, if you're using the Amazon EC2 service, then the Windows or the Linux updates are something that you have to manage again, network and firewall configuration there. So AWS will provide the features for the networking capabilities like security groups which are firewalls for EC2 network access control lists and they give you the ability to encrypt your communications as well.

But you ultimately have to utilize those resources and those features to make sure that your data is properly protected. So the free boxes in the middle here in blue, it's all about encryption and protecting your data at rest and in transit, all your responsibility underlying all this, of course, um We have aws and aws will provide the regions, the availability zones, the edge locations, those are the ones for Amazon cloud front and they're gonna manage all that global infrastructure, including the security of it and then the various services on top of that. So you've got the infrastructure layer compute storage, database networking and more. And then all the software on top of that.

So they are obviously responsible for that. They say that they are responsible for security of the cloud and you're responsible for security in the cloud. So just to show you this in a slightly different graphic here, you can see the customer responsibility on the top and the AWS responsibility on the bottom. So things like managing the data in your buckets that's up to you as is creating things like roles, setting up multi factual authentication, configuring security groups and network access control lists.

This is all a customer responsibility along with things like patch management. And then underlying that, we've got the actual database servers, disk drives, physical network switches and routers and the software layers, the control planes that sit on top of them. And of course, the data center security, that's no longer something you have to worry about. So that's the AWS shared responsibility model.

There's much more information on this, on the Aws website. It is important to understand this split of responsibilities so that you know what you're responsible for and what Aws will be providing.


### 11. Application Programming Interfaces (APIs)

Hey guys and welcome to this video in this video. I'm going to teach you about application programming interfaces or API S. Now, this can be quite a confusing subject. I think it was quite a few years before I really fully understood what they were from when I first started hearing about them and it was never really explained to me that well, but API S are integral to the cloud.

So they're a really important concept. Now, let's start off by talking about ports and protocols just for a bit of basis here. So if we're using a computer to connect to amazon.com, so the website amazon.com, we're gonna be using a browser, web browsers, use a protocol that is http, the hypertext transfer protocol or HTTP S which is the secure version with encryption. Now, the protocol is essentially the language that's used for communication over a network.

So http is used over the internet. It's a really great protocol for the internet. It's very reliable across the internet, which can have varying performance. Now, on the Amazon side, there's something called a port and the port is going to listen for incoming connections.

So I often refer to it as uh a door behind which a service is running. So there's lots of different doors with different numbers on them just like in the hotel and behind each of those doors is a service. So in this case, there's a web service and web services run on port 80 for http and port 443 for http S when we have encrypted connections. So these are common ports.

Now, the http protocol has something called methods. They're sometimes known as verbs as well. We have the get method. This is retrieving information.

So when you're connecting with your browser to amazon.com, your computer needs to download some pictures and some text maybe videos and display that information onto your computer. So it's performing a get request, your browser is submitting a get request to amazon.com. Now, if you're uploading data, you're gonna be using post or put. So the post is the method used to submit data.

So up load something and then if something needs to be subsequently replaced, then we're using the put method. And then there's the delete method as well for deleting data, there's more than that. But those are just a few to give you an idea of what the HTTP methods are. So coming back to our example of amazon.com, the computer is submitting an http get request to the web server and the web server is then returning the content to the client.

OK. So why am I talking about ports and protocols. And http. The reason is with API S, we're actually leveraging these common protocols.

So in API it stands for application programming interface and it's essentially a set of rules and protocols that allow computer programs to talk to each other, just like a web browser, talking to a web server. The API S assist with sharing information and data between those programs and they leverage standard protocols like http. So when we're leveraging the cloud, we're actually able to speak to Amazon or Aws. In this case using HTTP via an API AWS have API S and those API S define the actions that you can request on Aws.

So it's almost like a uh a menu in a restaurant and you can choose what you want. So what action do you wanna perform on Aws? Maybe I wanna launch a web server, maybe I want to delete something, maybe I want to create a database or maybe I want to create a new user. Now, the computer here which is on the internet is able to use the AWS management console in order to perform actions on Aws.

Even when you're using the management console, everything is resulting in an API call to Aws. So it doesn't matter whether you're using the management console, the visual interface, the command line interface or if you're a developer writing code using an SDK, you're always speaking to the AWS API. So maybe here somebody wants to create a new user account. So they do so through the visual interface of the management console.

But on the back end, what's actually happening kind of behind the scenes if you like is an API call is being made to Aws. And it's gonna use that language of the internet, http to speak to the API. So that means we're able to leverage the common language of the internet. We're able to leverage HTTP and the get put post et cetera methods in order to perform actions on Aws.

So it's a really great method of leveraging the internet and those standard protocols and web browsers in order to manage the cloud. And in this case, a user has now been created on AWS. So every single action that you take on aws is actually an API call. Again, whether you're creating databases or deleting Amazon S free buckets or updating a virtual server on EC2, everything is an API call.

Let's have a look at some more examples. So with Amazon S3, we have the get object API action. So you can imagine this is actually gonna result in an HTTP get request and that is to retrieve objects from Amazon S3. In other words, download a file from S3.

It's just a storage service basically. So here we have the API for S3 and through the management console, we're issuing an HTTP get in AWS language, that's an S3 get object request. And in response an image is downloaded to the computer. We could also upload objects to the bucket.

So here we're going to issue the put object API call. We have a PDF on the computer and we're able to issue the put objects and that PDF file is then uploaded to S3. So essentially every action that we wanna perform on AWS is going to be an API call. And we're leveraging this protocol of the internet http In order to make those requests, I'll give you another example that you may be familiar with.

Here, we have a flight aggregator service. So this could be something like Skyscanner, Ma Mondo, there are many others. So here you might wanna fly from, let's say New York to Dallas. So you put in your source, your destination, the time and date that you want to fly and what they'll do is they'll actually go out to the various airlines and find out which flights might suit your needs.

So we're searching for flights and what they're able to actually do here is talk to an API. So each of the airlines will have an API which means that the flight aggregator essentially just issues a request that says this is the information that we want to f we wanna find a flight that fits this criteria and then the API will return results and you as a purchaser can then choose which flight makes sense for you. So that's API S, it's a concept that's super important for the cloud because as I've mentioned, a couple of times, everything in Aws is an API call. So every time you're changing something, an API call is being made.


### 12. AWS Pricing Fundamentals

Hey guys, welcome to this video. In this video. I'm going to cover the fundamentals of pricing on AWS. So firstly, one of the components of pricing is compute here, you are charged for the amount of resources that you consume and the duration.

So for example, if you launch an Amazon EC2 instance, you'll need to choose an instance type. The instance type defines the amount of CPU ra M and storage that's allocated to that instance. Now for the CPU and RA M, you are charged based on the duration in which it's actually running. So if you run the instance for 24 hours, you will be charged and it's actually a per minute basis.

Now, on the other hand, if you shut down the instance, you're no longer paying for the CPU and RA M, but you might be paying for the storage. So storage is based on the quantity of data stored or allocated. So it does depend on the service here. For example, with Amazon S3, you are charged on the amount of data that's stored.

If you have a gigabyte of data, you pay for a gigabyte. If you have a terabyte, you pay for a terabyte. Now with Amazon EBS, that's the elastic block store. That's actually the volume that are attached to EC2 instances there you're actually charged for the amount of allocated space.

So you might create an EBS volume, that's a gigabyte in size, but it doesn't have much data in it. Maybe just a few 100 megabytes, you still pay for the full size of that storage volume. The third element is outbound data transfer. This is the quantity of data that's transferred out.

That means out of an availability zone or a region. So you've really got to understand this. This is something where companies can get a little bit tripped up. You never pay for data that you transfer into the cloud, but you do pay for data that's transferred out of an availability zone or a region.

So you've got to understand the various different charges there because they can actually amount to quite a bit of money if you're transferring large quantities of data. Now, we've got a few different frameworks. One is pay as you go. That's the default.

This is where you're just paying for what you use. And that of course, gives you lots of flexibility. You can easily adapt to changing business needs. You need 100 instances one day, only 10 the next day.

No problem. Terminate the ones you don't need or shut them down. And now you're only paying for 10 instances here, you can respond to change, of course, very easily and adapt based on needs and not on forecasts. Another pricing model is save when you reserve.

That means that you're actually reserving capacity. For example, with R DS, with EC2, with the elastic compute service, there's a variety of services which allow you to reserve capacity. Now, what you're doing here is you're committing for a period of time, one or three years and that means that Aws are gonna give you a discount. In fact, you can save up to 75% compared to the on demand pricing.

That's the pay as you go pricing, the more you pay upfront, the greater the discount. So for example, you can pay all of the amount upfront or sometimes you pay a partial amount upfront and then you pay some subsequent payments over a period of time. But in that case, the discount's not as great. So you're better off paying all upfront if you can, there's then the concept of paying less when you use more.

So here you get volume based discounts. As an example with Amazon is free. As you add more storage, you're paying a certain amount per gigabyte of data stored. But once you get to a certain threshold, any data above that threshold, the amount that you're paying per gigabyte reduces.

And then there's a third threshold, for example. So as you store more and more data, the amount you're paying per unit of data per gigabyte for example is decreasing. So that's a volume based discount, you're being rewarded for utilizing these services. So it's tiered pricing, meaning the more you use, the lower the unit pricing.


### 13. The 6 Advantages of Cloud Computing

Hey guys in this video, I'm gonna talk about the six advantages of cloud computing and this is not my opinion. This is straight from AWS. This is something that they refer to as being these core benefits you get from utilizing the cloud. The first one is that you get to trade capital expense for variable expense.

Now, a lot of CFO S will prefer operational expenditure instead of capital expenditure. Now, of course, this does depend on the economic climate factors like the cost of money and the interest that you might be able to get from your money. However, with Capex, you are outlying a large amount of cash. So if cash flow is a challenge for your business or money is essentially expensive for you as a business, you don't really wanna spend on purchasing services, you would prefer to use a pay as you go pricing model.

That's the opex where you're paying on a monthly basis. So Capex can be tax deductible over a depreciation lifetime that can be an advantage uh whereas Opex has another advantage which is that it's tax deductible in the same year. So again, this is all about sort of financial and how the cash flow of your business is being managed. The second one is massive economies of scale with AWS.

They have built this massive platform all over the world. They get very good pricing. Of course, on all of their compute many of which they manufacture themselves uh and their data centers and so on. And then of course, they have all these operational efficiencies of building the software, operational processes and so on and they're able to therefore pass on a lot of those economies of scale that they have created to their customers.

And as you can see on this list here, they, they have some of the biggest companies in the world as their customers. So a couple of things here is that you've got aggregated usage across hundreds of thousands of customers. And that means for you lower variable costs. Now the third is to stop guessing capacity.

I know that I've had this problem in my career. If you've been working in it for some time, you know what I'm talking about in the middle here, we have in green, what you actually needed in terms of the compute power for a server. And then in pink here we have what you thought you needed. So often we used to overestimate what we needed in terms of compute resources because it's better to say, well, I'll, I'm gonna purchase a server and I'm gonna say, well, it, it needs this amount of CPU and this amount of RA M and find out later that you provisioned a little bit too much than too little because too little means that you've got a performance issue.

But what it means is that over the course of, you know, lots of servers across a data center, you end up with a lot of wasted capacity. So that can become very, very costly. With AWS, you can just provision what you need. And if you find you need more resource or less resource, then that's quite easy and programmatic in terms of the way that you can then change, that might even be automatic.

The fourth advantage is to increase speed and agility. So that means that you get to deploy resources easily and quickly, you can leverage the huge amount of different services that are available for machine learning to analytics, to artificial intelligence, compute database, everything there in the cloud. It means that you can deploy applications and adapt to changing business needs really quickly. And that can be a huge advantage.

Agility is the the ability to react quickly to change, bringing out a product to market, for example, faster than your competition. If you're leveraging these cloud services, that can definitely be a huge advantage. Number five is stop spending money running and maintaining data centers. Of course, Aws don't want you to do that.

They would rather that you take that money that you would otherwise spend in data center management and put it into the cloud. Of course, that's good for them, but it's also good for you because it means that you can put it into innovation, you can instead of spending money managing servers in a data center, you're spending that money bringing new features for your customers, uh adapting quickly to business needs or changing market climates. So move the money into innovation instead, number six is go glow in minutes so easy in the cloud to start deploying your applications around the world. I know certainly as an architect of many years experience, I used to deploy things like databases and applications in different parts of the world for my customers and trying to do that was extremely complex.

It took sometimes months and a lot of money now I can do it in a couple of minutes in the cloud. Real huge advantage of cloud computing. Very easy now to start spreading our companies and our infrastructure and our applications around the world, getting them closer to different markets or different customers.


---

## Part 3: AWS Authentication and Access Control


### 14. Introduction

Hello and welcome to the authentication and access control section. So in this section, you're gonna learn all about the different services we can use for authentication and access control principally I am and I am Identity Center. There's some more coming in later on in the course as well. So we really need to understand I am first because it's one of the core services in Aws.

You have to learn about users, groups, roles and policies if we don't understand this topic. Well, it can cause us challenges down the road where we need to provide certain permissions to various different services or to our own user accounts as well. So we start off learning about I am. It's been around in Aws for a long time.

It still is one of the core services. Then we move on to I AM Identity Center. Identity Center is more around single sign on Aws are trying to encourage people to start using Identity center. And so I wanna show you around a service.

It's a really useful service in enterprise situations where you have integration and single sign on with other Aws accounts, business applications and Identity Federation as Well, so we're gonna set up identity center and you're gonna see how it works in action.


### 15. AWS Identity and Access Management (IAM)

Hey guys, welcome to this lesson in this lesson. I'm gonna cover the Aws identity and access management service known as I AM or also sometimes called IM. So I am is a really important service to understand because it's the service that we use for authentication and authorization. So here we have an Aws account with Aws.

I am. Of course, there's different ways that we can manage aws. We've got the console, we got the command line interface and the API through SDKS. So through I AM, we can create things like users and roles we can use Federated users and we can enable authentication for applications as well.

Now, all I am principles must be authenticated to send requests. In other words, to send any kind of API request to Aws. A principle is a person or application that makes a request for an action, that's an API action or operation on an Aws resource. Now, firstly, we have authentication.

So that's essentially proving that you are who you say you are, for example, by supplying a password, then we need authorization. Authorization is where we either are allowed or denied access to resources. And here we have policies like identity based policies and resource based policies which define what we are allowed to do. So first through authentication, we prove we are who we say we are.

Then AWS determines what we are allowed to actually do. For example, performing API actions like run instances on EC2 that launches a virtual server. Get bucket, retrieves information about buckets and create user means to create a user in I AM. So the API actions are authorized on the AWS resources.

A few of the core components of I AM are users, user groups, roles and policies. User groups are used for adding users and then applying permissions policies. So we have the user account, you can log in with a user account. We have the policy that determines what users are allowed to do.

What API actions are they allowed to take in the account or on a specific resource. And so the way that we apply these policies to multiple users is by attaching them to a user group. So if we have several people who have a common job role, we can attach a policy that provides the permissions, they need to do their job, put all those users in the group and now we only have one permissions policy to manage. So the user will gain the permissions applied to the group through the policy.

These are called identity based policies. They get applied to users groups and roles and roles are used for delegation and they are assumed we'll talk a bit more about that later. But essentially what's happening here is a role is an identity which has permissions assigned to it via a policy. And then you can assume the role and take on whatever those permissions are.

It's kind of like putting that hat on. That's why it's a picture of a hat. You might put a hat on for your development role and take on the development permissions. Maybe.

Then you're gonna do a S IOPS role. You take off your development hat, put on the the role hat for development and you become a developer. So that's what a role is. We'll look at that more a bit later on.

Now, the policies define the permissions for the identities or resources they are associated with. Let's look at I AM users in a bit more detail. When you created your account, you supplied an email address and that created the root user account. And as I've mentioned before, the root user has full permissions and you can't restrict most of those permissions.

So it's best practice not to use that account. What you should do is set a very strong password and enable multi factual authentication. Then we're gonna create user accounts. You can create up to five thou 1000 individual user accounts and those user accounts will have no permissions by default.

That's a really important point to remember. So if you create a user account that user can log in if you enable management console access, but they can't do anything at all unless you specifically apply permissions to them. So here we have a user, we've got Andrea. Now, Andrea, when she logs in will use her friendly name.

The friendly name is just a simple text string. In this case, it's actually her name, Andrea. So you can log in very simply with Andrea and then a password. Now there's actually for every resource in aws, there's an Amazon resource name.

OK? You can see that here. Now, the text in red is the account number. We can see a little bit.

It's an A RN. So it's an Amazon resource name. It's an AWS resource, it's an I AM resource. This is the account number.

We know that this type of resource is a user and then the friendly name is Andrea. So that's a unique identifier for that resource within A W SS. Now, Andrea can log in via these different mechanisms. We've got the management console for which you use a user name and password and potentially multi factor authentication.

And then for the command line interface and the API we can use access keys. So let's move on to user groups. Great thing about user groups is it helps us from a management perspective here, we've got the admin group, the development group and the operations group. We can add our users in some users might be in multiple groups and the groups are then used to apply permissions.

Ok. So now we can take a permissions policy that's relevant to those specific groups of users and apply it to the group and those users will automatically inherit those permissions. Now, if a user is in multiple groups, they will gain multiple sets of permissions and they are combined together. So the user will gain the permissions applied to the group through the permissions policy.

For authentication methods, we can use a user name and password with a multi factual authentication token. For that extra factual security, we can use that mechanism for connecting to the management console using an I AM account. So here John is also fated and perform operations through the console. Now, the other ways are the command line interface and the API for this, we need to gain some credentials.

There's a couple of ways of doing this. One is by generating something called an access key, id and a secret access key. It's kind of like a user name and password. And these can be used via the CLI and the API to authenticate to the AWS API.

And we can use something called the A W SS security token service to generate short term credentials as well. So access keys are used for programmatic access. I'll just finish this lesson by summarizing the differences between the root user and an I AM user. So remember that the root user is the one in which you log in with the email address that you used when you created the account and it has full access and is unrestricted.

Also difficult to restrict. Some permissions cannot be restricted for the root user account. There are some actions which you need the root user to perform. But mostly once we've got our account up and running, we don't need it so we can lock it away and not use that account.

And then we have our I AM user which has a friendly name. And we, when we log in using this user account, we will supply either the alias for the account or the account ID itself. And the permissions assigned to an I AM user come through permissions policies. If there's no permissions policies apply to this user directly or via any groups that the user is a member of, then they won't have any permissions.

So you have to enable permissions by assigning policies either directly or usually preferably through a user group instead.


### 16. [HOL] Creating IAM Users and Groups

Welcome back in this lesson. We're going to head to the I AM service and we're gonna create a user account that we can log in with and assign that user account to a group. And then I'm gonna show you how you can actually log in as that user. I'm back in the AWS management console.

I'm gonna click on I AM and I'm in the identity and access management service. Now, what we're going to do is we're going to create a user at the moment. There are no user accounts in this account. First, I'm gonna create a user group, the user group is the way that we're gonna assign the permissions to the user account.

So we assign the permissions to the group and then we add the user to the group and the user will inherit those permissions. So what I'm gonna do here is create a group. I'm simply gonna call this one admins because the account I'm going to create is gonna be an administrative account. Then I need to attach a permissions policy here.

I'm gonna choose administrator access. This is a very powerful policy. The policies are written in javascript object notation if I expand the policy here, we can see the JSON code. So here this statement is fairly straightforward.

The effect is to allow the action is a star. A star is a wildcard, it means anything. So any action, all actions and then the resources are star as well. So another wildcard so essentially allow all actions on all resources so you can do anything.

So that's what I want for this particular user account. So I selected administrator access and then in the bottom right hand corner, I'm going to create that group. So now I have my admin group. Next, I'm gonna click on users and create user.

I'm gonna provide a name. I'm simply gonna call my Neil. Next, I'm gonna select this option to provide the user with access to the management console. That means I'll be able to log in to the management console rather than just using programmatic access methods.

Now, here we're given a choice, we can create an I AM user. But what Aws are recommending is that we use the I Am Identity Center. Now, I am identity center provides some amazing features like single sign on it provides access to business applications and multiple accounts. It's a very, very useful service and Aws are now trying to encourage people to start using it.

We will get into that later in the course. However, we do need to learn. I Am as well because it's core to the Aws exams and it's what I'm gonna use for a lot of. So I'm actually using I Am for most of my accounts because I don't need single sign on in many cases.

So here we're going to create an I AM user. I'm gonna set a custom password and I'm gonna deselect this requirement to change the password at the next login. And then I'm gonna click on next. We now have the option to add the user to a group, which is exactly what we're going to do by selecting admins.

We could also copy permissions from existing users or attach policies directly. But when we want to create multiple users who have the same permissions, it's better to create a group rather than attaching policies directly to every individual user account from a management perspective. It's much easier. Now, I've selected my group, I'll click on next and then create user.

Now we're presented with the console sign in details. We already know these from earlier on. This is what we're going to use to log in. I'm gonna copy this so I can go straight across and show you how to log in as this user account.

We know that the user name is Neil and the console password is available here for us to copy. Uh At this point in time, we won't be able to see it again. We would have to change it in the future if we forget what it is. So I'm done with creating the user account.

I can return back to the user list here and I'm going to open a private window so I can log in separately. So here I'm using a private window. I'm gonna paste in the sign in link for I am. This takes me to the login page.

I'm gonna enter my user name and then my password and then simply sign in. So now I'm signed in and I'm signed in with my individual user account for some reason. It's, it's put me into Ohio. I was in us East before.

So let's just change back to us east. Most of the labs that we do in the course are gonna be run using North Virginia. It's not always essential, but often it is required depending on the code that we provide for you or the specific instructions that we show you. So you can now see that I'm logged in as Neil at D CD lab training.

Ok. So I'm logged in as my individual user account and this account has full administrative permissions so we can use it for all of the lab exercises that we're going to perform in this course. And from now on, you should be logging in with your individual I am user account and not with your root account.


### 18. [HOL] Switching IAM Roles

In this lesson, I'm going to show you how to create an I AM role and then with a test user account, we're gonna switch to that role in order to gain some permissions. I'm in the Aws management console here and I've navigated across to the I AM service. You might wanna add I am to your favorites as well. So you can get to it easily.

I'm logged in as my individual I am user account. So we already have a user, I've created my personal user account and a group called Admins and my user account has permissions via the admins group. What I'm going to do now is I'm going to create a user and I'm gonna call this one, Joe. I'm gonna provide management console access.

I do want to use an I AM user and I'm gonna set a custom password and remove this option here to be forced to change it at the next log in. Let's click on next this time. I'm not going to add any permissions. We're just going to create the user account.

So we've now created a user account that essentially doesn't have any permissions if I click on the console, sign in link. I'm gonna go to a private window and log in as Joe. So here I am in a private window. Let's use the sign in link to log in, enter Joe as the user and the password and let's sign in.

So I'm signed in as Joe. We can already see that we're getting some access denied issues here. I'm gonna navigate to the EC2 service virtual servers in the cloud. So let's click over to EC2 E two is where we can run virtual servers running Linux and Windows and even Mac Os.

Now, when I come onto this page, the first thing you see is a lot of red, that red is API errors and those API errors are essentially telling us we don't have permissions. So in other words, I'm not able to view the number of elastic IP S or load balances or snapshot because the API failed and it failed because I don't have the permissions. So we can see here that this user account does not have permissions in I Am. So what we're gonna do is we're gonna create a role that does supply those permissions for this user and we're going to then try and switch roles so that the user can take on the relevant permissions for on a temporary basis while they need to perform actions.

In EC2, I've changed back to the I AM console logged in as my individual user account where I have admin permissions on the left hand side here, I'm gonna click on rolls and then I'm going to create a role, the trusted entity is who is able to assume this role. I'm gonna choose AWS account. I'm gonna leave it on this account and then I'm gonna click on next. And now what I'm going to do is I'm going to search for EC2.

We can see lots of different permissions policies that include EC2. Let's use EC2 full access. Maybe Joe needs every now and then to launch virtual servers in the cloud. So this one will provide quite a few permissions for load balancing EC2 and a variety of related services.

OK? So with that selected, I can now come down, click on next, give this a name, I'll call it EC2 roll and then we can scroll down to the bottom and click on create role. Now, before I do that, you can see that there's something called a trust policy here. This defines who is able to assume this role.

In this case, people within the account are able to assume this role. OK? So now I can click on create and the roll is done. If I click on the roll in the console here, we can now see that there's a link, a link to switch roles in the console.

So let's click on that link and we're gonna see if Joe can actually assume this role. Now you might be thinking, hang on a minute, there's something missing here and actually there is, I'll show you in a moment. Let's come back to where Joe is logged in and in the top right hand corner, I'm going to expand the menu and click on switch roll, click on, switch, roll again. Here.

I need to enter the account number and the role that I'm connecting to and the display name. OK. So you can send out that information manually. Or as we were about to do, we actually have the URL.

So I'm gonna paste in the URL that I copied from another screen and it fills that information out for me at the bottom. Here, I'll give it this a name for the display EC2 roll and let's click on switch roll. Now, if it works, we'll be taken straight into back into EC2 with the relevant permissions. If it doesn't, it will look like nothing really happened.

OK? So we can see nothing's really happening. I'm clicking on switch roll. It's not being allowed.

Why is that the reason the user cannot switch roles is because they don't have a particular permission that they need. The user needs the STS assumed role action. They don't have that permission at the moment because the user was created without any permissions. So what we need to do is provide the user with this particular permission.

Sts assume role, then they will be able to assume the role and then gain the permissions that are assigned to the role. So what we can do is we are going to use this policy. We do need to make an update, we need to add in the A RN of the role into here. Now, by the way, this permission statement can be found in the sts assume roll dot JSON file which is in the I AM directory, aws, I AM of the course download, you can get the course download by clicking on the link in the last lesson of section one of the course back in AWS logged in as myself.

I'm on the page in I am where I can see my role. I'm gonna click on the A RN here to copy it to my clipboard. Then I can simply paste this in to where it says resource here. And now we have a permission statement which is going to allow our user to assume the role with this specific A RN, right?

So I can copy all of this code to my clipboard back in. I am logged in as myself. Let's go to users Joe and under permissions. I'm gonna click on add permissions, create in line policy and then choose the Json tab.

I'm going to delete all code in here and then paste in this permission statement. OK? So there should be eight lines here. Click on next, give the policy a name and then create the policy.

Now let's go back to where we're logged in as Joe and see if Joe can assume the role here. I am logged in as Joe, I'm gonna click on switch role and now it completes successfully. We can see in the top right hand corner that the user is logged in as EC2 dash roll. That's the name of the role that we created.

And now let's head over to EC2 and most of the errors have gone. There's some here which are not related to EC2 itself, but the user does now have permissions to EC2. So you can feel free to go in and launch instances, do whatever you want. You now have those permissions.

So you can see the power of this, Joe might not need these permissions on a daily basis. So according to the principle of least privilege, we don't want to provide those permissions to Joe's user account, but we'd rather that Joe assumed a role when he does need those permissions and then switch back to his own account when he doesn't need the permissions anymore. That's a more secure way of operating. So now the user has full permissions to Amazon EC2 in the top right, we can always go and switch back and that will take us back to Joe's account.

And now of course, all the errors reappear because we've given up those permissions


### 19. IAM Identity Center

Hello and welcome to this lesson in this lesson. I'm gonna cover the I AM Identity Center. Identity Center is becoming a very important product on Aws. And in many ways, Aws is steering us towards using Identity center instead of I am for many use cases.

Identity center is the successor to the Aws single sign on service. Aws sso it's basically the same product but renamed and it enables centralized permissions management and single sign on. So that means we can utilize Identity center for single sign on with many different other providers and business applications. Now the identity source itself.

So where the user identities are stored can be identity center directory, it can be active directory and standard providers that use the SL 2.0 protocol. Now for identity center to connect to an on premises managed directory, you can use the ad connector or Aws managed Microsoft ad depending on your requirements. There's then built in single sign on integrations to many different common business applications and we get single sign on two different Aws accounts including accounts that are part of an organization. So let's have a look at a comparison between I AM and Identity Center.

I am is for managing access to Aws services and resources. Identity center provides that centralized identity management and single sign on not just to A W US services but then to other external services, other accounts and business applications. Now for Identity Federation, I am supports federation to external identity providers using SAM L the security assertion markup language and open ID, connect identity center builds on that with built in federation with external ID PS and it's streamlined for ease of setup and management. So it's easier to get it up and running in terms of multi-account access with I am.

It requires a bit more of a complex set up. We need to do things like assuming roles across accounts with identity center. It's easier to grant users access to multiple accounts and applications with a single login. We then have integration with business applications.

I am not really there, it's limited to Aws services. There can be some integration, but it's a more of a custom set up. So it's a bit more complex. Whereas with Identity center, this is exactly what it's there for.

It's built, it has those built in single sign on capabilities to a lot of different business applications. For example, here we have salesforce and office 365 as well as Aws accounts as well. So much easier with Identity center. So at the bottom here, of course, single sign on that's what identity center's all about, you can do it through federation with I AM.

But again, it's a bit more complex. Whereas identity center is built specifically for this purpose in terms of use cases with I AM. It's about managing Aws resources and permissions and creating and managing I AM users roles within Aws and then federating with external identity providers for single sign on to Aws. So you might have your identities in an active directory.

For example, you can then create that integration through federation into Aws. And then you get access from those user identities in your ad into Aws services. But really, it kind of is limited to that. It's harder to then gain access to other accounts and business applications.

You've got programmatic access management and fine grained access control free policies. We can get right down to a very detailed level in terms of the permissions we want to assign with identity center. It's all about single sign on, not just the Aws resources and accounts, but to non Aws applications as well. And it's a centralized identity management.

So if you've got a complex environment, it's gonna be better to use identity center. And it also helps you with integrating with external directory services, making things easier and again, ease of access to those business applications from a single sign on perspective because that's exactly what it's built to do. And lastly, Identity Center provides a nice user experience with a user portal as well.


---

## Part 4: Amazon EC2, Auto Scaling, and Load Balancing


### 21. Introduction

Hey guys, welcome to another section in this section. You're gonna learn about one of the most important services on AWS and one of the oldest as well. The Amazon Elastic compute cloud Amazon EC2. You'll learn about how you can scale EC2 with automatic scaling.

You'll also learn how you can load balance for high availability and fault tolerance as well. So we'll start off learning about one of the fundamental concepts which is server virtualization. Easy two is basically virtual servers in the cloud. It means that you can launch windows Linux and even MAC servers in the cloud and you pay for the amount that you use very, very simple and very fast.

It can be as quick as you know, a few seconds to launch an operating system in the cloud. Now, we wanna be able to scale elastically, that means scale out when we need more instances, more compute power and then scale back in again when we don't need the compute power anymore. So we can save cost. So you'll learn about how you can do that with Amazon EC2 auto scaling and then load balance the incoming traffic to the various instances.

And they're spread across different availability zones. So we have high availability within a region across different data centers. Of course, it's gonna be very hands on. I'm gonna show you how to launch EC2 instances manually and then we'll see how we can do it automatically with auto scaling and put load balances in front of those instances.

So it should be a lot of fun working through the exercises in this section. And EC2 is not just an important service for us to consume direct. It's also a very important service in Aws because it's an underlying service for many other Aws services as well. So for example, the Amazon relational database service runs on EC2 instances as does Amazon elastic cash.

In fact, many Aws services under the hood are running on EC2. So lots to get on with, I'll see you in the next lesson.


### 22. Server Virtualization

Hey guys and welcome to this lesson. So in this lesson, I'm gonna talk about server virtualization now. This is a technology that's been around for quite a long time and it underpins the cloud. So services like Amazon EC2 leverage virtualization.

So let's look at what it is in case you haven't been exposed to it before. So let's have a look at an example of a server when we're not using virtualization long time ago, we didn't have virtualization. So this is what we built. We had a server which obviously has some hardware in it and that hardware is composed of the CPU the processor.

We've got the ra m the random access memory, we've got some storage, we've got a network adapter, there's other components as well, but these are the main important ones then we have the operating system. So this would be Linux or Windows or some other operating system. On top of that, we now install our application or our service. So this could be a web server, it could be a database server, it could be a file server, whatever it is, the service is running as well.

Now, some of the limitations of this model are firstly the operating system that OS is top to the hardware layer. So there's tight integration between the operating system and hardware, meaning that it is not portable. It's not easy to move that particular operating system with its application to another piece of hardware. If for example, you need to perform some maintenance or maybe even the server fails, it often leads to underutilized resources.

So we end up with lots of wasted capacity. It's just not a very efficient way of utilizing the underlying server. And that leads to higher costs, of course, and scalability constraints. So what if we suddenly need a lot more compute power?

We either have to add that compute power to that underlying physical server. Maybe we have to literally open up that server add in some memory cards, for example, or we have to find a way to get that operating system and application move somewhere else unless we can scale horizontally. That's another topic. But this is a few of the limitations of using this model where we didn't use virtualization and longer deployment times.

Cos we need that hardware like of course as well. So then we move to a model where we have a virtualization layer that is called a hypervisor. So we have our physical server and then we have the hypervisor software on top. For example, VMWARE, we've got Zen, we've got KVM, we've got Microsoft Hyper V.

Those are a few examples of hypervisor software. So the hypervisor creates a layer of abstraction between the physical server and what runs on top, which is a virtual server now also known as a virtual machine. The hypervisor allocates or emulates the physical resources to the virtual machine. So the virtual machine actually gets a subset of the resource sources that are available.

Now, we can have an operating system and a web service or whatever our application layer is within that virtual machine. Now, virtual machines, virtual servers or instances, that's the same thing. It's just different terminology for the same thing. It's a virtual server running with an operating system on top of a hypervisor.

Now, one of the great benefits is we can now run multiple virtual machines and therefore multiple operating systems and multiple applications on one underlying server. In fact, we can have many, many virtual machines. So for example, here we have a hypervisor and it's got lots of virtual machines. Every one of these could be running a different operating system and a different application and they're all running on one server.

We also have portability. So now these virtual machines can be easily moved between servers because they're not tied to that underlying hardware the way they are without virtualization. So we get quite a few benefits. The virtual machine is portable, we get better resource utilization and therefore that drives lower costs and we have great scalability as well.

So now we can easily scale because we can add additional hypervisor servers underneath and we can move our virtual machines around and provide the capacity to the virtual machines as we need. We have very quick deployment times. You want to launch a new server, as long as your underlying hardware infrastructure has the capacity, you can deploy them very, very quickly. Indeed.

OK. So that is server virtualization in a nutshell. Now, server virtualization has been around a long time, around about 20 years or so ago. It became very popular.

I spent many years migrating lots of physical servers to virtual machines. But now it's a very well established technology. But the reason I need to make sure you understand it is because it does underpin the cloud. Lots of aws services run on top of a hypervisor.


### 23. Scaling Up vs Scaling Out

Hey guys in this lesson, I'm gonna cover the difference between scaling up versus scaling out. Now, one of the important things to understand before we get into scaling is state full versus stateless applications by stateless application. I mean, let's say an example here of somebody checking a website. Now, this website is a weather website doesn't need to record any information about you.

It just shows you what the weather is at this point in time. That means there's no state recorded about the user session. They don't need to remember you next time you come back to the website. On the other hand, a user might be browsing amazon.com and purchasing.

In this case, it is a state full application because they're gonna record information about what products you saw. So they know what to recommend or advertise to you what you purchased so that you've got that history. So all of that information is gathered and that means that the application is state full. Now, let's take an example of a e-commerce application here.

We've got a web server application layer and then a database on the back end. So cart items are stored in cookies on the computer. That means the state is not on the actual web server. The web server itself is stateless.

There's no information stored about the user there. However, there is some information about the browsing history. In this case, on the client side, when the user makes a purchase, then the application layer will process the order and record the data in the database. Now, the database is of course state full because it has to record this information about the purchase that the user made.

So that's the difference between state full and stateless applications. And you'll see why it's important shortly. So we've got scaling up. Now, scaling up is also scaling vertically.

It's the same thing, just two different ways of saying it. So here we have a virtual machine an instance if you like and it has an operating system and a web service running and of course, it has a certain allocation of resource CPU memory storage and network bandwidth. Now, what if we need more resources for this individual operating system? Well, the way that we can do that is of course, we can add more resources to the server in the virtual world.

That's fairly straightforward. But usually you have to shut down the server, you have to then add the additional hardware through a software configuration if it's virtualized and then boot up that virtual machine again. Now on the other hand, we've got scaling out here, what you do is you add more instances of that particular application. So if it's a stateless web service, we've now got six instances running in the cloud six virtual servers, all running the same web service.

And what we wanna do is load balance between them. OK? So they're all actually taking a bit of load from the requests that are coming in. So that's scaling out or scaling horizontally now just to put it into AWS terms.

if you have an EC2 instance, let's say it's a T two micro that only has one VCPU and one gigabyte of RA M. So if you wanna scale it up, provide more power for that individual virtual server, you can change the instance type to AC five dot X large here and that has four VCP US and eight gigabytes of RA M. So that of course, is scaling up scaling vertically. On the other hand, what we could do instead is we can add additional instances and that would be scaling out.

So now we have eight T two micros rather than one C five. Obviously, it depends on your needs. But now you're spreading the load over more instances, which means if one fails, it's less of an impact than if you have one server that has your application running on it. But it does depend on what we're actually doing with that instance.

What is the application? For example, if you have a database like my SQL, typically you're gonna scale that up. Certainly, in terms of the ability to write to the database, there's ways that you can shard and separate relational databases. But what you need to do to provide more power to that individual part of the database is you scale up, provide more resources to it.

On the other hand, if you have a static website, so nothing is changing, then it's easy to scale out because now you can have multiple instances. And if you load balance, so the connections that are coming in are going to each of the instances, it doesn't matter which instance a user ends up on because they're all exactly the same. Now, if you have a dynamic website, things change a little bit because then you are actually storing some kind of state. So what you need to do as an architect is work out how you can externalize that state.

That's something for another lesson. But there, what you wanna do is take the information that's stored in the file system and put it into an external service like Amazon EFS, for example, and you might wanna take any databases that are uh installed there and externalize those into dynamo DB or a relational database like Amazon R DS. So that's scaling up versus scaling out. And of course, we would prefer most of the time and Aws always prefer scaling out wherever possible because you're spreading the load, you're diversifying your risk a little bit as well.

If an individual instance fails and you can spread across multiple availability zones in the case of EC2. But for some use cases or some applications, you do need to scale up.


### 24. High Availability and Fault Tolerance

Hey guys, welcome to this video. In this video, I'm going to cover the differences between high availability and fault tolerance and how we can enable high availability on AWS. So high availability refers to ensuring that we have minimal service interruption for our applications or services. So whatever we're running on AWS, we wanna make sure that it's available for use as much of the time as possible.

So therefore, we need to design with no single point of failure. We can assume that things are going to fail even on AWS. Therefore, we have to make sure we build in redundancy with high availability, we measure it in terms of the up time. So and it's a percentage number.

So we've got 99.99% here. That means 99.99% of the time the application should be available. We can use synchronous or asynchronous replication here. So with synchronous replication, when one system replicates data to another, it waits for a confirmation to come back to say that the data has been successfully received and written with asynchronous, there's no sort of wait for that data to come back to confirm that the uh the system has received and written the data.

So asynchronous is a little bit faster, but it can result in data loss if there's a failure during that time frame. With high availability, it's typically a lower cost compared to fault tolerance. In terms of services that we can use. We've got elastic low balancing for distributing incoming connections to different targets and we can spread those targets across multiple availability zones.

We've got auto which makes sure that the there's enough targets available and if one fails, it replaces it. And then we've got route 53 which is a DNS service and it can be used to respond to queries for the IP address of the application in various different ways, either in a load balancing way or it can also be a sort of fail over manner as well for disaster recovery. Now, in this lesson, we'll look into auto skating and load balancing in much more detail. So on the other hand, we've got fault tolerance here, you're looking for no service interruption whatsoever and therefore you need specialized hardware that provides instantaneous fail over.

There should be no downtime at all with fault tolerance. Even if one or more components fail in a system synchronous applications, the only um the only fault tolerant replication mechanism because with asynchronous, it could potentially lose data. And with fault tolerance, you want to ensure that there is zero data loss, there's definitely a higher cost here compared to high availability. A few examples are fault tolerant network interface cards, disk, mirroring, raid one and synchronous DB replication.

We'll have a look at some of these in a moment and then you've got redundant power, of course. So every server should have redundant power supplies and your data sensor should have redundant power sources as well. So let's have a look at fault tolerance here. We've got a computer system that has ac pu ra M hard disk drive and a network interface card.

Now, if that network interface card fails, we've lost the network. If we lose a hard disk drive, we've lost the whole system, it won't work anymore. So here there is no built in redundancy. So what we wanna do instead is we can implement a second hard drive and this is where we might use raid one which is dis mirroring.

So that's a technology that mirrors the rights. In other words, every time a right is made to the disk, it goes to both disks at the same time. So they're exact copies of each other. And there's a specialized hardware adapter that will instantly fail over.

If one of those disks fails, then we've got a second network interface card as well. So now if one network interface guard goes down or one hard drive, no problem, we have fault tolerance because we have redundant components in the system. Now, on AWS fault tolerance is taken care of by aws for the most part, you can implement raid one, but you don't really need to cos there's a lot of durability in Amazon ebs the elastic block store, things like uh network interface cards. Again, they built in the redundancy.

You can add additional NICS into your instances, Enis you can attach them to your instance, so you can add that level of fault tolerance to your systems. But a lot of the fault tolerant components, things like the power supplies. Of course, in the servers, the redundant power sources for the data center, the redundant networking components in the underlying infrastructure layer, aws takes care of all of that. Now, what we can do is we can enable high availability on top of those fault tolering components of the underlying infrastructure.

Let's have a look now at how we can implement high availability on top of that fault tolerant infrastructure that Aws provides. So here we have a load balancer and you can see that some users have connected to that load balancer and they've been distributed to multiple web servers across multiple availability zones. And of course, each availability zone is essentially a separate data center can be more than one data center, but they are definitely separate data centers from each other and they all have their own redundant power sources and redundant networking and they're physically different buildings as well. So now we have lots of redundancy here.

We've got several web servers across those two A Zs, the connections have come in. They've been distributed nicely. Of course, if we had thousands of people connecting, they would just be load balanced across this infrastructure. Now, what if web server two fails here?

If it fails? Of course, the connection is broken, but now that user is redirected to web server four. So no problem at all. There is a little bit of service interruption but not too much.

Now, what's gonna happen is Aws auto scaling is going to replace that web server. So now we've got the amount of web servers that we want back again. And of course, auto scanning can automatically ensure that there's always enough to service whatever the load is for the application at that point in time. Now, what if an entire A Z fails here?

We've gone down to one A Z. Well, that's ok. We've still got two web servers and we can launch more if we need more capacity. But even in the event of an entire availability zone failing, we still have access to our application.

And now we can see those connections being redirected to web server one and web server five here. Lastly, I just wanna cover the differences between durability and availability. You'll see these terms referenced a lot in terms of data storage. So durability is protection against data loss and data corruption.

And S3 offers 11 nines of durability. So what does that mean? Well, you can see there it's 99 points and then nine more nines. So if you store 10 million objects in S3, you can expect to lose one every 10,000 years.

That's what that level of durability means. It means the chance of your data being lost is extremely low. So you're less worried about data loss and data corruption availability is different. So availability is a measurement of the amount of time the data is available to access.

Ok. So your data might not be lost but you can't access it. So it's expressed as a percent of time per year. So now we've got 99.9 9% so much the same as what we were looking at before with high availability and fault tolerance.

We're looking here at the ability to access our data. How much of the time can we actually access it? Many services on Aws have very high durability and in some cases like S3 and EFS, you can choose the level of availability you want and you'll pay a bit more if you want higher availability.


### 26. [HOL] Launching Amazon EC2 Instances

In this lesson, I'm gonna show you how to launch virtual servers on Aws using the Amazon EC2 service. And we're gonna launch a Linux instance and a Windows instance. So when we're launching EC2 instances, we need to first select our instance type. So there's lots of different instance types and of course, they come with varying amounts of CPU and memory and storage as well.

So we're gonna pay depending on the amount of those resources we require for most of the lessons in this course. If not all of them, we're gonna use the T two dot micro. This is a general purpose, easy two instance type and it's within the free tier. So the instance type defines the hardware profile and therefore the cost, we also need to select an Amazon machine image.

The AMI S define which operating system we want to use and how it being configured it might have, for example, an application pre installed on it. You can choose an Ami that has Windows with a Microsoft SQL server database installed as an example. So the AMI defines the configuration of the instance, including the operating system and any software that's installed and how the virtual drives, the EBS volumes are defined. Now, these are backed by what's called a snapshot.

So the actual data is stored in a snapshot. Snapshots are actually taken from live instances as a kind of backup and then we create an AMI from them and we can keep launching more instances that are the same as the original. So a snapshot is a point in time backup of an easy two instance. Once we've done that, we can create our own customized ami S.

So for example, we might launch an existing AMI, we might make some customizations to it and then create our own ami that we can then launch instances from later on. So that's a little bit of theory. Let's head over to the console and start building this out. I'm back in the management console.

I'm going to type EC2, add it to my favorites and then click on EC2. OK. So now on the EC2 management console, we've got a little bit of information here. We've got on the left hand side, we've got all the various different features and we can start going and working with resources by clicking on one of those on the main page here.

We just get some summary information as well. There's a nice tile on the top right hand corner here which tells us how much of the free tier usage we've actually used. So that's very useful. So what I'm gonna do is click on launch instance.

This is the same as going to instances here and then clicking on launch instance. But I'm just gonna use the button on the screen here. So now I can name my instance if I want to. That's optional.

Well, I'm gonna call this Linux dash server. Let's scroll down a little way. Now, we can see the application and OS images, the Ami the Amazon machine image. Now by default, it's selected the Amazon Linux, that's a version of Linux that's been customized by A W SS.

It includes a variety of things like it includes certain agents and the command line interface for AWS. The Amazon Linux, AMI has been customized by AWS and includes certain agents and the AWS command line interface. So it's very useful. So here we've chosen the Amazon Linux 2023 Ami that's actually been selected for us and it says free tier eligible, which is good news.

Now, if we scroll down a little way, now we've got the incident type. So here T two micro is selected by default free tier eligible. That's good news. If we wanted to change it, we could click on the little arrow and then we can choose from one of the different options here.

I'm gonna leave it as it is. Next, we have the key pair, key pairs are used for connecting to our instances using the secure shell if we're connecting from outside Aws, for example, now I don't have any key pairs. So I'm gonna create a new one. I'm going to leave the default Rs A and dot Pe M and I'm gonna give this a name that's descriptive.

So I'll call this DC T lab training dash us E one. And then I'm just gonna create the key pair. Now, what's gonna happen is that will have downloaded a to my computer. This is actually using cryptography, public and private keys.

The private key has been downloaded to your computer. It's probably in your downloads directory. Make sure you move that somewhere where you can find it later on and where it is kept securely because it is sensitive information. Anybody with that particular file will be able to connect to your instances and manage them.

Ok? So that's all we need to do there for. Now. It's selected the key pair for us.

Once we've created it for network settings, we're going to leave some of the defaults here, but we need to create a new security group. Now, if I do it from here, it's gonna give it a weird name. OK? So rather I would prefer to click on edit and then I can actually give it a name and I'm gonna call this web access.

I'm gonna copy that name into the description and then here we have SSH OK. That's all I need for. Now, secure shell and it's going to allow any source address. The zeros means any source IP address.

That's all good news that gives me the ability to connect. Ok? So let's scroll down a little way and we're gonna leave the con storage as the defaults. And actually that's all we need to do for now.

There's some more advanced options. We'll get to those in another lesson. I just want one of these instances. I'm happy with the summary here.

So I'm just gonna launch so that instance is launching, I can click on view all instances and we can see that it's pending. So that should change to a running state soon. We can see lots of information by clicking on the instance. And now I can see it's instance ID, a unique identifier, public IP address, the private IP address.

It also has a public and private DNS name that we can use and there's various different tabs for monitoring information. We can see the security group we assigned. So that's essentially the firewall that's allowing access on port 20. In this case, there's lots of networking information we can see it's in the US East one D availability zone.

And this is going to have been deployed in our default virtual private cloud, which for now is fine. We'll get on to some more details about that later on. So that is now running. That's great.

Let's launch another instance. I'll call this One windows server and we're gonna scroll down here and choose windows. Now, by the way, you'll notice there's this browse more Ami S, let's see where that takes us. If I click on browse more Ami S, we've got the quickstart, Ami S got my Ami S.

If we have our, our own custom Ami S, they'll be in here. There's marketplace Ami S. So now we've got lots of Ami S that include various software like VPN servers, backup and recovery software, networking, firewalls, like Palo Alto Splunk enterprise and so on built into the instance. And typically you'll pay a higher rate for these because the software charges are going to be included.

That's not always the case, but that's sometimes the case. And then there's community AMI S which people in the community have created and shared for everyone else to use. And in fact, I'm gonna cancel out of that one, come back to here and just click on Windows and it chooses for me, the Microsoft Windows server 2022 base. That's great.

Again, it's gonna be a T two micro for the key pair. It is very important for the Windows instances that we select this. We don't always need to assign a key pair for our Linux instances because we can often use a service called cloudshell to connect to them if we want to connect using the secure shell protocol, which I'll show you in another lesson. However, for Windows, in order to retrieve the password, we have to have a key pair assigned.

So select the key pair name under network settings. We're gonna select an existing security group and choose web access. Now, in this case, web access does not have the rule that we need to connect to Windows at this point in time. So we're gonna have to go and edit that in a moment.

So that's all I need to do. I can click on launch instance and now I'm gonna have my Windows instance up and running shortly. Let's go back to check it out. If I refresh the page here, we can see two different instances.

By the way, you can filter by state up here. So for example, if I filter by running, I only see my running instances. So sometimes that happens for you by default. So if you can't see what you're expecting to see, make sure it's set to all states.

Now, I need to be able to connect to my windows server and I want to use the remote desktop protocol. So under security here, I can see that I have a security group which has port 22 open. That's not for the remote desktop protocol. That's for the Linux server when we use the secure shell protocol.

OK? So I can click on the security group here to edit it or on the left hand side under network and security, we can choose security groups and I can find the same security group here. I'll click on the ID. We have inbound and outbound rules.

I only want to edit the inbound rules at the moment. So I'm gonna click on edit inbound rules. I'm going to add a rule, click on this box here and I'm going to type RDP to easily find the RDP protocol which will allow access on port 3389. And then I'm going to change to anywhere I PV four allowing any source address and then save rules.

So that's it. We've launched our two instances and we have to wait a couple of minutes for the Windows instance before we're gonna be able to connect to it, the Linux server would be ready now. And that's what we're gonna do in another lesson. We're gonna leave these two running and I'm gonna show you how you can connect to Linux using the secure shell protocol and windows, using the remote desktop protocol.


### 27. [HOL] Connecting to Amazon EC2

Welcome back in this lesson. I'm gonna show you how to connect to your EC2 instances using the secure shell protocol and the RDP protocol. So you should have your Linux and Windows instance running in EC2 back in the EC2 management console. I've selected my Linux server.

Now, we can see that we've got a public IP address and we've got a public IP DNS address as well. So if we want to, we can use those to connect from the outside world. Now, let's have a look at the various different ways that we can connect. If I click on connect with the instant selected, we can now use the easy two instance connect.

That's what we're about to use or we can use session manager. This is using the systems manager service. It's one of the features of systems manager gives us a very secure way of connecting without opening any ports. We've then got the SSH client.

So if you wanted to connect from your home computer, this is what you could use. You'd need your private key pair, uh your private key file that is so remember earlier on, we created a key pair and it downloaded a file to our computer. That's the private key file and it actually gives us the full command. So we can see the command is SSH dash.

I, then the name of the PE M file, that's the file that was downloaded the key pair. So yours is gonna be different and then EC2 user, ec2 dash user at and then we've got the public DNS name or this could be the public IP address. That would be the full command that you would need to connect from your home computer. Now, I recommend if you're using Windows, you do install an SSH client.

It is a feature of Windows. So you just have to Google how to do that for your particular version of the operating system. If you're on Mac, for example, you'll always have an SSH client installed, same with Linux. Now, what we're gonna use today is EC2 instance connects here.

We're gonna connect using E two instance, connect the s the connection type on the left. The right hand, one is for where our instances are within a private subnet. And we have to create something called an endpoint first. But our instances have been launched into the default BBC, which by default has public subnets only.

That means they have public addresses and we can connect to the instances directly from the internet. Now, the user name has been specified as EC2 dash user. That's correct. I'm gonna leave that as it is and let's click on connect.

I'm now connected to the command line on my easy two instance, if I run something, like if config it shows me the IP addresses associated with the instance I should be able to ping google.com and get a response. And that proves that I can actually connect and then I have to hit control C by the way to stop that. Otherwise, it would just keep sending those ping requests over and over again. So that's good.

That will work successfully. Now, if you do have any issues here, if a little red banner comes up saying it can't connect, there's two main things which you need to check. Firstly, you do need to have a public IP address. Secondly, your instance must have the port 22 open in its security group.

So click on security port 22 with the source should be all zeros. That's any source address. That's what that actually means. OK?

If you've got those two things selected, then instance connect should definitely work with the Amazon, Linux ami. OK? So that's Linux very, very easy to connect. And now we're free to manage this server from the command line.

So next, let's move to Windows for Windows, we're gonna select the server, we're going to click on connect. The options are slightly different. Now, there is an option for session manager for remote powershell on the command line, but we're gonna use the RDP clients. So that's the remote desktop protocol.

What we have to do here is we can download the remote desktop file and that's gonna download a file to our computer, which we can utilize or we can add the information directly for this exercise. You will need an RDP client. That's a bit of software on your computer. If you're using Windows, it's easy.

There's always an RDP client installed. If you're using Mac like I am, then you have to download and install it. But you can find an RDP client on the internet. So just search for RDP client Mac and you'll be able to find some software to install.

What I need to do is get the password for login. Ok. So we're gonna do that in just a moment. Firstly, I'm gonna copy the public DNS name.

We can see that the user name is administrator. Ok. That's fine. Now, with my remote desktop software, I'm gonna click on add PC.

Enter this as the PC name and click on add. Ok. So now it's ready to go. And what's gonna happen is I'm gonna connect and it's gonna ask for the user name and password.

Now we need to go and retrieve the password first. So I'm just gonna cancel out here until I've got that information to retrieve the password. We click on get password and now we need to upload the private key file. So I've uploaded my private key file.

That's the one that I downloaded in a previous lesson when we created that key pair. Ok, you can select the file and it's going to download all the contents for you. And then we can click on this option decrypt password and I can see the password. I know that the user name is administrator.

So I'm just gonna copy the password and back in my ID P client. I'm going to double click, put in the administrator, user name, put in the password and then continue and let's continue again. And that should connect me to the desktop of the server. And there we go, I'm being logged into the desktop of a windows server on AWS.

So here we are, we have the Windows desktop. This server is now ready to administer. Now, as with the Linux server, we need to have a certain port open for all this to work. So if it failed again, you can go back and check by clicking on your windows server, selecting security and checking that security group.

And you need to make sure that you've got port 3389 open and the source has to be from anywhere. That's the remote desktop protocol. So that's basically it. We've now launched two virtual servers in the cloud running Windows and Linux and I've shown you how to connect to those instances so you can administer them.

I finished with my Windows instance. So I'm gonna go ahead and terminate the instance. So up in the top menu here, you can choose instance state, you can stop instances. And that means you're not going to pay for the running compute and memory.

You will still pay for the storage that's allocated to this server. You can reboot instances. And of course, you can terminate instances as well. And that essentially deletes them.

When we click on terminate, we'll find that the instance changes to a terminated state fairly quickly and then it will stay in the console here for a while. Don't worry about it. It will disappear after a little while. The other thing that we can do in terms of administration under actions, there's a variety of other settings and we're gonna go through many more of these as we go through the course.

But for now I'm leaving my Linux server running.


### 28. Access Keys and IAM Roles with EC2

Hey guys and welcome to this lesson. So in this one, I'm going to talk about access keys and I am roles two different ways that we can actually supply permissions to Amazon E two instances. So let's see how this looks. So here we have an instance in a public subnet and AWS cli has been configured with access keys because we wanna work with an S3 bucket from the command line on this particular instance.

Now the actual access keys are associated with an account. So whichever account created the access keys, that's the account they're associated with and they pick up the permissions assigned to any permissions policies assigned to that I am user. So essentially through this, I am user, we've created access keys, we've configured the command line interface on the instance with those access keys. So now whatever commands we run on that instance will have the same permissions as that user would have.

So now we've found a way to give our instance permissions problem is when we use access keys, these are long term credentials and we wanna try and avoid using them as much as possible because if they're compromised and someone gets access to those keys, they get access essentially to our account and they are actually stored in plain text on the actual instance itself. So not really the most secure configuration instead, what we can do is we can utilize I AM rolls rolls have policies assigned to them. So now we can supply the permissions that we want our instance to have. There's no credentials stored on the instance.

So we don't have that security exposure that we have with those access keys. Now, the instance is going to assume the role and gain the access permissions that it needs on the S3 bucket. OK? So two different ways of performing the same thing.

But the second way, this way is more secure than using access key. So we wanna try and use this method whenever we can. One thing to note when we're using I AM rolls is it is utilizing the AWS security token service, Aws sts in order to gain credentials. So it's actually gaining essentially access keys.

But those access keys have a much shorter expiration and the instance will automatically renegotiate with Sts and get some new credentials before they expire. So it's all happening automatically in the background. And those shorter term credentials are of course more secure than if we have the long term ones stored in plain text on the computer. So this is the best option we're gonna use these as much as possible.

That's it for this. Lesson. I will see you in the next one.


### 29. [HOL] Practice with Access Keys and IAM Roles

Hey guys in this lesson, we're going to work with access keys and I am roles on Amazon E two instances. So let's head over to the console back in the console here. I still have a Linux server running has a public IP address and I'm able to connect to this instance. So let's go ahead and connect using easy two instance connects.

So I'm logged into the console. I can run commands on windows. Now, the great thing about the Amazon Linux 2023 AMI or one of the great things is it has the AWS command line interface already installed so I can run commands like AWS S3 LS. But when I do so I get this message unable to locate credentials.

You can configure credentials by running aws configure. So it basically means we do not have any permissions. That makes sense. Even though I have permissions under my user account, Linux, the operating system does not have any permissions.

That's a good thing. We don't want it to inherit permissions from us. In fact, we're actually logged in as a user called easy two user. That user account does not have too many permissions on.

Linux certainly doesn't have any permissions to any Aws services. So, what we need to do is supply those permissions. Now, there's two ways of doing that. One is through access keys.

That's when we use the Aws configure, the other is an I AM role. So let's head over to the I AM service and open that up in a new tab. And what I need to do to, to get some access keys. I'm gonna click on users, choose my user account, go to security credentials and then we're gonna come down here to where it says create access key.

I'm gonna choose command line interface as the use case. And straight away you can see there's a bit of a warning here. There's better ways of doing this and there certainly are. This is not the recommended way to actually administer your servers or provide permissions to your servers so that they can access aws applications.

The role is the better way for now. I'm ok with this because I just wanna demonstrate it to you. Let's click on next. I don't need a description and create access key.

Now this information is displayed to you. Now you can retrieve the access key later on. You can only retrieve the secret access key now and optionally you can download it. This is very important information.

This is essentially like a user name and password because anyone with this access key and secret access key are able to perform api actions in your account and they will inherit your user permissions. OK? So very dangerous. Watch out for that.

Now, I'm gonna copy the access key come back to the server and I'm gonna run that AWS configure command. It's now gonna ask me for the access key ID, I'll paste it in. It's gonna ask for the secret access key. I'm gonna copy that come back, paste it in and then it wants the region name or the default region.

I'm gonna set mine to us East one with dashes in between and press enter and enter again. So now let's try and rerun that command from earlier aws S3 LS and no response there. That actually means that we didn't get an error. That's good news.

Ok? So that just means we now have permissions. In fact, I can run a service like AWS S3 MB to make a bucket. This will create a container.

I'll call it my bucket and then make it unique with a bunch of random characters that creates a bucket which is basically like a folder that you can store data into. So now when I rerun that command, it actually comes back with a response and it shows me the buckets in my account. So that's just proven that we now have access to Aws services. Sounds good.

However, there are some security problems here. If I change directory to this weird directory path, we can see and by the way that's the, the tilda slash dot aws. And now we can see these two files, config and credentials. Interesting.

What's in those? I'm gonna use the cat utility. So cat config and in here we can see some of that information I entered when I ran Aws, configure the default region that we specified. But what about the other one, cat credentials?

Oh, now I can see my access key and my secret access key. Remember, this is highly sensitive information. It's there on the hard drive of this computer. It's there in plain text for anyone who can get into this user account.

If there was some kind of compromise of the server and they found this, they've now compromised your entire aws account. So it's not really very good. Here's what I'm gonna do. I'm gonna change directory upper level.

Ok. So now we've got those two commands. Let me just clear screen. So now I'm back in my use directory.

I am going to run RM dash RF tilda slash dot aws slash star. Ok. So let's remove those credentials. Let's rerun Aws S3 Ls.

Ok. No credentials. They're gone. Now, let's do it the better way.

Let's go back to I am and we're going to use a roll. Now, I've actually shown you my access keys, which is not very secure. Of course, because that's very sensitive information. So what we can do with our access keys is we can always deactivate them and after you've deactivated them, you can delete them.

Ok? So now it's no use to anyone. So let's just copy this into the confirmation delete. Now, my account is secure again.

So let's go to rolls. We're gonna create a roll for E two and here we're gonna choose the Aws service this time. So under use case with AWS service selected, I'm gonna type EC2, choose EC2 and then I'll leave the default option. Click on next.

Now, I need to supply some permissions. Let's provide S3 read only access. It's a useful permission to have. I'll call this 1 S3 read only and then it's just scroll down.

We can see a couple of things here. So the trust policy very important. Remember, the trust policy with a role defines who is allowed to assume the role, who is able to perform this action, sts assumed role who or what? In this case, it's a service.

So it's the principle is a service and it's E two. And when EC2 assumes this role, they will, it will gain these permissions. So let's create the role that's done. Now, we need to go back to EC2.

Select the instance, go to actions, security and modify. I am roll. Now, the roles that appear here are the ones that have that trust policy. So we've just got the one at the moment S3 read only.

Choose that option, select update I am roll and that's done. That should take instant effect. Let's rerun that command and now we get our bucket returned. So now we have credentials again.

But guess what? There's nothing on the hard drive of this computer that, that directory with the credentials in does not exist anymore. I deleted those files. They're gone.

My hard drive is secure. There's no plain text data stored in here for credentials that will essentially supply people access to my account so much better to use rolls which leverage those temporary credentials which don't get stored on the computer. Ok. So that's it for this lesson.

I will leave that role where it is because it is useful. Sometimes we'll use it in other labs, but I'm finished with this particular Linux server. So I'm going to terminate this instance and that's it. We're all cleaned up.


### 31. Amazon EC2 Auto Scaling

In this lesson, I'm going to cover Amazon EC2, auto scaling, auto scaling is a really important service for maintaining the availability and automatic scaling of our EC2 instances. What it does is it will automatically launch or terminate instances based on whether the instance needs to be replaced or or potentially you need to increase or decrease the capacity of your cluster. So you get to maintain the availability of your application and then scale it in response to certain things like changes in demand. It works with many different services.

So we have EC2, it's actually launching and terminating EC2 instances, the elastic container service where it can be used to launch or terminate the nodes on which the actual containers run. And the same for the elastic Kanit service as well. It integrates with quite a few different AWS services. A few of the important ones are firstly cloud watch for monitoring and scaling your instances are constantly sending information to cloud watch and that be information such as metrics on the CPU utilization that information can be utilized by auto scaling to determine whether it needs to scale the cluster out or in.

So adding more nodes or terminating nodes. We've got elastic load balancing for distribution of connections. If you're automatically scaling your instances. So auto scaling is adding instances to the deployment, then you wanna make sure that the load balancer knows about that so it can send incoming connections.

So there's an integration there between the A SG the auto scaling group and the load balancer and E two spot instances for cost optimization. Amazon VPC. Of course, because we want the EC2 auto scaling group to deploy the instances within a VPC and across availability zones. So let's have a look at what it looks like in a nice diagram here.

So here we have two availability zones each with a subnet doesn't matter whether it's public or private, this one's public and we create an auto scanning group and then we can define the number of instances we want to be running in that auto scanning group. So here we might have to find that four is an acceptable number. That's how many we want to run at a steady state. Now, there's two different scenarios, I'm gonna show you here.

One is automatic scaling. So what's happening all the time is the instances are sending through information to cloud watch depending on the type of monitoring, either basic or detail that's either every five minutes or one minute. So they're sending metrics to cloud watch, things like the CPU utilization. Now, if the metric reports that the nodes have in aggregate exceeded 80% utilization of their CP US.

Cloudwatch can notify autos scale to actually add a new node. So it's gonna launch a new instance into that Autocad group. And this is all happening within Cloudwatch using cloudwatch alarms, alarms get created with certain thresholds for uh CPU utilization. And once those are breached, either instances need to be launched or they need to be terminated to bring the cluster back down to a number that's appropriate to the amount of demand at that point in time.

So we wanna cost optimize as much as we can. Now, the second scenario is maintaining availability. Of course instances can fail. For some reason here, the status checks have failed on one of these instances.

So again, e two auto scanning is able to launch a replacement because that node failed. So those are the fundamentals of auto scanning. It's maintaining availability and scaling based on demand. So scaling out when we need more instances and scaling back in again by terminating instances when we no longer need them.

And of course, it's gonna talk to the load balancer to make sure the load balancer knows where to send incoming connections with auto scaling. The scaling is horizontal, we're scaling out. So we're adding instances or we're terminating instances. So it's providing both elasticity and scalability elasticity is the scaling out.

But then elastic means that it's able to scale back in again as well. So we're not just adding capacity. We're removing it when we no longer need it, auto scanning will respond to E two status checks as well as Cloudwatch metrics and it can scale based on demand so the performance or we can do it on a schedule instead. So we can say, well, we know that we're gonna need more capacity at a certain point in time, maybe 9 a.m.

on a Monday morning when people are starting to utilize the application more. So we can scale on a schedule ahead of that point in time to make sure we've got the capacity if we want to. And it's scaling policies that we create, which define how the auto scaling group will change to demand based on those metrics or based on schedules. So let's have a look at the config we have something called a launch template.

This specifies the EC2 instance configuration. Few of the things that it in includes which are perhaps the most important to point out is firstly the Ami so the Amazon machine image, what's the operating system and configuration of the software within the operating system that we want to use for our instances. So of course, we can create whatever um operating system ami we want with our application preconfigured if we want to. And then auto scanning is just gonna launch many instances that are exactly the same.

We choose the instant type EBS volumes, uh things like instance profiles for I AM. If we need to supply permissions to the instances and so on. There's also something called a launch config these are still available. They're older, they've been replaced really by launch templates which have more options.

So generally we're gonna be using launch templates now in both cases, whichever one you use, we then get to configure things like the purchase options on demand versus spot for our auto scaling group. We get to configure the VPC, we want deploy our instances into and which subnets across which availability zones we can optionally attach a load balancer as we're deploying our A SG or at a later time as well. And you can configure health checks for both EC2 and elastic load balancing. And you get to configure the group size and the scaling policies, you can either statically define how many instances you always want to have running or you can use the scaling policy then to either adjust dynamically or on a schedule.

A few more key facts. So health checks, these are really important. We've got the EC2 health checks that the auto scanning group makes. That's essentially an integration into the EC2 status checks.

So it's looking at what's coming through from the EC2 status checks is the system? OK? Or is it impaired in some way we've then got the ELB health checks. These are used in addition to the EC2 status checks.

And this just means that we're also able to receive information in the auto scaling group about what the load balance that is seeing happening. So the load balancer is also doing its health checks to the instances. If they fail, it's gonna report that information back to auto scale. So it knows that it should terminate and restart that instance.

We've got something called a health check grace period. This is how long to wait before checking the health of an instance. So we don't want the health check to start too quickly. If for example, we're running some kind of bootstrap scripts or we're installing some applications and maybe the application's not quite ready yet.

So we can give a little bit of a grace period to allow the system to come up once it's been launched and become operational. So auto scaling doesn't act on health checks until that period expires. So we have different types of auto scaling. We've got manual that just means you're going in and manually making changes to the A SG size.

So the number of instances you want deployed in the auto scaling group or we have dynamic and that automatically scales based on demand. So now we're looking at those cloudwatch metrics, there's something called predictive as well, which uses machine learning to predict what it thinks is going to happen based on what it's seen in the past. And then lastly, you got scheduled where you're scaling based on a schedule that you define. So when you expect you're going to need more or less capacity.


### 33. Amazon Elastic Load Balancing

Hey guys in this lesson, I'm going to cover Amazon elastic load balancing. So load balancers provide high availability and fault tolerance. Essentially they are a single end point. So a single DNS name or IP address behind which a bunch of different instances sit.

So it's gonna automatically distribute connections to those EC2 instances. Now it's not just EC2 by the way. So targets include EC2 instances, also ECs containers, you've got IP addresses as a target as well and LAMBDA functions and also other load balances. So you can actually chain them together.

There's some use cases where that's advantageous. So let's have a look at it in action. So here we have a few easy two instances deployed in an A SG and autocall group across multiple subnets in different availability zones. So when users come in the low balancer is automatically distributing connections.

If an instance fails, then it's going to be taken out of action. Now elastic low balancing will perform health checks. So the target group, that's the collection of the targets that you define some characteristics for in some configuration settings, the target group is going to perform health checks. So it's gonna check those instances.

For example, if they are web servers, it might connect on port 80. So the http port and just check a certain URL path to see if it gets a P A positive response, a 200 return code. Now, if it gets that success code, then it's going to s assume that that instance is healthy and working and operational. If it doesn't, if it doesn't get a successful response, then it's going to assume that instance is out of action.

So after a few tries, it's gonna take it out of action and it's gonna redistribute connections to a different EC2 instance. This is the point where the low balancer can also with integration into auto scaling, notify auto scanning that this instance is not responding to health checks and auto scanning will terminate and then replace that instance. So here user, one is actually reconnected from instance one to instance four so that their session continues. The ELB takes the instance one out of service because of the failed health check and then auto scanning is going to terminate it and then of course, it can replace it.

So now we have instance five replacing the first instance that was terminated previously. So now we have that level of availability and fault tolerance across multiple availability zones as new users come along, of course, they get distributed. Now by default, autos scanning is going to try and spread the load across multiple availability zones and the load balancer sitting in front is then gonna distribute connections to all of the instances. And again, through integration between auto scanning and load balancing as the auto scanning group launches those instances, it's going to notify the load balancer.

So the no low balancer actually knows that they there and then can start sending connections through to them. Now, we've got a few different types of load balance. So there's an old one called the classic load balance. So I'm not gonna cover that because it's really been deprecated quite a long time ago, but it's still there in the console.

So the important ones are the application load balancer. So this one is a layer seven load balancer that means it understands information in the http and http S headers, ok. Layer seven. So it can perform things like path based routing or host based routing and a few others.

So path based routing is the path in the URL. So if it's slash orders versus slash my account, it can actually send the connection to a different set of targets in a different target group. So that's path based routing. And that's obviously a le layer seven function.

It actually has to look into that URL. It's not just looking at IP addresses and port numbers. Now, these listeners are always http or http S next. We have the network load balance.

So this is the connection level load balance. So we say it runs at layer four because that's where these port numbers are the TCP ports and the UDP ports, for example, those protocols run up later four. So with this type of load balancer, it offers extremely high performance and extremely low latency. So watch out for those kind of uh keywords if you're taking an exam because they often come up.

So this is the one for TLS offloading as well at scale. So it's very high performance load balancer. One of the other features of the network load balancer, you can have static IP S so those are elastic IP S in each availability zone. So that means you can hard code those white list them in firewalls.

For example, lastly, we have the gateway load balance. A very different thing here. What this is actually used for is virtual appliances. So virtual networking appliances like firewalls, intrusion detection systems, intrusion prevention systems.

So we're actually able to load balance some of the incoming traffic through to those virtual appliances where they can perform some kind of inspection. So it's using the Geneve protocol instead here. So different low balancers for different use cases, let's have a look at what those might be. So for the application load balancer use this one when you have web applications, http and http S and you need that sort of layer seven routing capability.

It's good for micro services architectures like Docker containers, lamb lambda targets, which are an option with the A LB with the NLB TCP and UDP based applications extremely low latency, high performance and static IP addresses as well as VPC endpoint services as well. And then lastly for the gateway load balance. So this is where you wanna deploy scale and manage third party virtual network appliances. It gives you centralized inspection and monitoring capabilities.

So we're talking about firewalls, intrusion detection, intrusion prevention systems, deep packet inspection systems and other similar virtual network appliances.


### 34. [HOL] Create an Application Load Balancer

Welcome back in this lesson. I'm gonna create an application load balancer. Now we've already got an auto scanning group running. So you should have two instances across two availability zones.

We're gonna put an A lb in front of our auto scanning group and we're gonna direct traffic to the application load balancer. Then in another lesson, we will adjust the auto scanning configuration to add a scaling policy. And we're gonna test actually adding some load to our auto scaling group back in the E two management console. If I just give this a refresh, I should have my two instances running and they're running through my auto scaling group.

Now, the first thing I need to do for low balancing is go ahead and create what's called a target group. So the target group is going to contain the instances. Let's click on create target group here. We need to choose what the target type is.

We've got instances IP addresses lambda functions and application load balancers depending on our scenario. And the low balancer, we're using some of these options might not work, but in this case, instances is compatible with our application load balancer. We can see for example that Lambda functions are a possible target as well, but only for application load balancers. And you can even use an application load balancer as a target for a network load balancer.

So let's make sure that instances is selected. We'll give it a name. I'll call it TG one here. We need to choose the protocol.

In this case, it's gonna be http cos we're gonna create an application load balancer. So http port 80 that's where my web server is running. Ok. So I want traffic to come in on http port 80.

Next for IP address type. I'll leave it on I PV four. Http one, the health check protocol is gonna stay on http and slash health checks are performed by the load balance. So to check that the instances are actually healthy, they're operational.

In this case, it's gonna check on the default port for http which is port 80 and it's just gonna check the route of the website. You can add a path on here. If you want to, to check a certain path or a document, you can also set advanced settings like the thresholds for unhealthy instances before they're taken out of time of operation, for example. So I'm gonna leave those as default settings.

Let's click on next here. You can add your instances by including them as pending below, but we don't wanna do that. I'll show you why in a moment what we want is we want a dynamic assignment so that every time the auto scaling group launches new instances in response to changes demand or a failed instance. For example, it's going to automatically add them into the target group.

If we do it here, we're statically defining which instances should be in the target group. So don't do that. Let's just create the target group that's done. Now, we can create our low balancer.

So let's choose low balancers on the left, create low balancer. We need to choose which low balancer we want, we want an application low balancer for this use case. So let's click on create, I will call it simply A or B one. It's gonna be internet facing internal would be for, for example, maybe your application logic layer or your back end is in a different private Subnet and your load balancing traffic internally.

In this case, it will have a public DNS name that we can connect to from the internet IP address type will be I PV four VPC is the default. I'm gonna select the US East one A and one B subnets and availability zones because that's where my instances are actually deployed for security groups. I deselect this option and then add in the web access security group. So not the default change to your web access security group, then we have to define the listeners and the routing.

OK? So the load balancer is going to listen on a certain port and protocol. It's listening for connections using the http protocol on port 80. When it receives those connections on the listener, it's gonna route the connections through to the target.

The target is TG one the target group. In other words, the instances that are attached to that target group. So that's all we have to do here. We can come down and create the load balancer.

Low balancers take a few minutes to become operational. So on this page here, we can see some of the details of low balancer. If you come up a level, you just see the basics and you can see that it's provisioning here. We have the DNS name.

So the DNS name is what we're gonna connect to the low balancer with once it's up and running, it should become active after a few minutes. Another place you can go to see what's going on is the target group. So we come back to target groups. Click on TG one here.

We've got targets. If I click on refresh, there's no targets. Now, remember I said that I wanted to set this up. So the auto scanning group was going to automatically register the targets.

So let's go and do that. We're gonna come back to auto scaling, click on the auto scaling group. I'm gonna scroll down the page a little bit to where it says load balancing, click on edit, select application network or gateway load balancer target groups and then select TG one and click on update. Now, let's go back to target groups and on my target group page, I'm gonna give this a refresh and let's see if we've got any targets.

We go to targets refresh here and there we go. We've got two targets that have now been registered in the target group. Now, the health status is initial, the low balance is not ready yet. So the health check at hasn't even begun once the low balancer is ready, which should be quite soon, then the health status should change to healthy as long as that website is up and running and the security groups are set up correctly.

Cos remember we need to be able to perform this health check on the health check port and protocol that is http and the pathways are slash http uses port 80 by default. So the security group for the instances must allow connections on the http port. Let's come back, give it a refresh. And I think it's gonna be long now and very soon we will see this change to healthy.

Once we see healthy instances, there we go right now. It happened dynamically, we are now ready to actually test the load balancer. So I'm gonna come back to the load balancers here, select my mobile answer, click on DNS name to copy the DNS name to my clipboard and then let's go over to uh new browser window hit enter and we can see that we've hit the web page of one of our instances in us east one A. If I refresh the page, it changes to us east to one B.

So I've been low balanced between two different availability zones, essentially two different data centers. It's pretty cool. If I just keep refreshing, we can see I keep getting low balanced across those two availability zones. So we have the traffic being spread equally between those two A Zs.

So that that's it for this lesson, the load balance is up and running auto scaling is working in the next lesson. What we're gonna do is create a scaling policy. We're gonna add a whole bunch of load to our front end so that we then generate more back end load which will cause the auto scaling group to react and scale. So I'll see you in that lesson.


### 35. [HOL] Create a Scaling Policy

Hey guys. In this lesson, we're gonna create a scaling policy so that we can set some dynamic scaling on our auto scaling group and then generate some load and cause it to scale. I'm back in easy two, I have my auto scaling group with two instances running. I have a low balancer in front that's running as well.

So we can generate connections to the low balancer and it's currently low balancing us between two instances. So what we want to do is adjust the auto scaling group and create a scaling policy. Now there's no point creating a scaling policy when our desired min and Max are all the same. Firstly, we have to change that.

So in the auto scanning group, I'm gonna click on edit and I'm gonna increase my max desire capacity to four. OK. So now I have four instances, I'm gonna potentially run and let's click on update. Now.

Also, I want to make sure that we spread these across more availability zones. So I'm going to edit network here and I'm going to add in us East one C and us East one D. So now I've got even better high availability, but I also have to do the same thing for the load balancer. So on the low balancer front end, we can select the load balancer, click on network mapping and then click on edit subnets on the right hand side here.

So we need to make sure that the low balancer is also going to distribute connections to us east one C and one D and then we can save changes. So now we've adjusted the load balancer and the auto scaling groups networks. The next thing to do is go to automatic scaling and we're gonna a dynamic scaling policy. So I'm going to click create dynamic scaling policy here.

We have some different options, target tracking step and simple. I'm going to leave the target tracking, scaling selection and rather than CPU utilization, I'm going to change it to application load balance. So that request count per target. That's the number of connections that are reaching the targets.

I'm gonna select my target group. I'm gonna leave this value at 50 so 50 connections per target. If we exceed that number, it's gonna start scaling and then I'm simply gonna create this scale policy. So that's ready once we created the scaling policy, if we head across to the cloud watch service, we will see that it's created some alarms for us.

So we head into cloud watch. This is a performance monitoring service under alarms here. If we go to all alarms, we can now see these two target tracking alarms have been set. It says insufficient data hasn't really received enough information yet to make a uh to make a to have an opinion alarm high is going to be triggered when the request count per target is greater than 50 for free data points in three minutes.

That means it's gonna scale out. But we gotta wait, we gotta generate load and then we've gotta wait for a few minutes so that those d data points come in. Then after a while as the request count per target gets lower under 45 for 15 data points within 15 minutes, then it will scale back in again. So it's a bit of a slower scaling in is a bit slower than scaling out.

We want to make sure that we have enough load and we make sure that maybe that spike in demand is actually over before we scale back in again. So this is all set up correctly. We're ready to scale. What we need to do is come back to our load balancer.

And what I'm gonna do is just bring this down. I'm gonna copy the DNS name for the load balancer in the course. Download in the Amazon EC2 directory. We've got this generate load on a lb markdown file in here.

We have this command. What we need to do is we need to replace this address here. So I'm just gonna paste this in. And in fact, I do need to keep the http colon slash slash.

So just pop the DNS name in here and this is a four loop, what it's going to do it, it's gonna create 200 connections to the low balance. So using the curl command and we'll just run this several times. I'm gonna copy this whole command, not using these um these little dashes on either side. So just copy that command.

We're gonna come back to the console here and I'm gonna use cloudshell. You can just do this from your computer as well on the command line if you wish to. But I'm just gonna use cloudshell. So let's open up cloudshell.

I'm gonna adjust the font size here, make it a bit bigger. So you can see what's going on and I'm gonna paste in this command. Let's press enter. So what's happening is it's actually bringing back the web pages very quickly.

OK? It's actually pulling back everything that's on that web page. So we can see lots of connections are being to the load balancer. So I'm just gonna run this command several times.

We're generating load. Remember, we have to generate quite a bit of data. Uh More than 50 connections per target. We've got two targets.

So running this a few times is easily going to exceed that amount. But we have to wait for the collection of free data points in three minutes. So it's still gonna take several minutes. I just keep running this a few times and then eventually we'll see what's happened and we should find that we have a alarm that has changed into a alarm state.

So at the moment we see we've got ok for the high that will change to alarm state at some point soon. So run that a few times, just make sure you keep running that command several times and then we're gonna have a look in a few minutes time and see what's happened back on the low balancers page here. I've headed over to the monitoring tab and you can see this massive spike in requests. So we know that this information is coming in.

You can also go to instances as well and you can have a look at the monitoring tabs for the instances here. You can see CPU utilization network in network out. So we're not exactly seeing requests here, but you can see some of the load that's being generated, not a huge amount of load because it's very simple to serve that web page. Now, if we go back to the cloud watch console here, let's have a look.

It's still not quite there yet. So I'm gonna run this a couple more times and then we should find that it changes to an alarm state fairly quickly. Ok. Here we go.

The Cloudwatch alarm is now in the in alarm state. If I click on the alarm, we can see some monitoring information here as well. So we can see this massive spike in requests that came in. So let's head back and have a look at the auto scaling group and see what's going on there.

So we come back down to auto scaling, click on the auto scaling group go to activity and we can see that it's already picked up that change. There's a couple of different entries here about launching a new instance and that's based on the target tracking alarm, high alarm, which has been triggered. And we can see if we go back to the details here that now the desire has been changed to four. So that's automatically been adjusted for us.

If we head up to instances, we can see here, let's refresh. We should see that we now have four running instances. Ok? These ones are just booting up.

We can also go and check if they've been registered into the target group. So target groups, let's refresh here and they're not quite there yet. In fact, there's a third one. So we've got um we've got 1234.

Ok, let's just see what's happening here. So we've got one left that's not quite healthy, shouldn't take long and then we should have four healthy instances. There we go, we have four healthy instances. So let's go back to low balancers copy the DNS name again, put this into a browser window, hit enter and now we should cycle between ABC and D not necessarily in that order, but we're certainly being cycled and load balanced across four different availability zones now.

So essentially four different data centers pretty amazing. There we go four different instances. So that is auto scalding and load balancing. We can see that now our application is going to dynamically adjust to demand.

It's going to launch and terminate instances through auto scaling to make sure we have the right amount of capacity and then the low balance is automatically going to pick that up and send traffic to those various targets. So I have finished with this lab. Now, all I need to do is just go and terminate a few resources. So what we're gonna do is come back to auto scanning groups and I'm going to delete the auto scaling group.

Now, what you'll f you'll find is that because these instances are associated with a low balancer, it's not going to terminate them immediately. In fact, if we go here, it's gonna tell you that connection draining is in progress. So what that does is it just waits to make sure just in case there's still some open connections to the instances. So that will take a couple of minutes.

Don't worry if they don't get terminated immediately, that is normal, but they will be automatically terminated by auto skiing. If you wanna hurry things up, you can go and just terminate them through the instances page as well. The other thing I need to get rid of is the load balancer. These are the two things that could end up costing us money if we leave them running for too long.

So that's gone. The target group doesn't cost us anything. The instances will be automatically terminated when they're out of service. Ok.

We see they're in a draining status at the moment. Likewise, the launch template doesn't cost us anything. It's there if we need to use it again at some point in the future.


---

## Part 5: Amazon Virtual Private Cloud (VPC)


### 36. Introduction

Hey guys, welcome to the Amazon virtual private cloud VPC section of the course VPC is very important component of AWS. It essentially gives us the ability to create a virtual data center in the cloud, a virtual network space in which we can define our subnet and IP ranges and then we can launch instances and other resources into our VPC and it's all under our control and separated and isolated from other VPC S and other AWS accounts. There will be a few more advanced concepts in relation to networking in this section. So I'm starting off with an overview of some very important concepts like the open systems interconnection O SI model.

I do go into some more advanced topics here in terms of networking. The open systems interconnection model is a really useful standard to understand if you're gonna be involved with networking in the cloud or anywhere else for that matter. Also, you need to understand about routers, switches and firewalls and how they work. And IP addressing very important concept to understand you need to know how to set up your IP ranges in the cloud.

So I'm gonna go over those topics, give you that foundational understanding of these networking concepts. And then we'll look at how we can implement networking in the cloud with a VPC. So I hope you enjoyed this section. I'll see you in the next lesson.


### 38. Routers, Switches and Firewalls

In this lesson, I'm going to cover routers, switches and firewalls teach you some of the basic concepts associated with these. So here we have a network and this network is composed of several computers attached to each other using a switch. So the switch is the networking communications device that they're interconnected with. Now, a switch is known as a layer two device.

On the right hand side, we have a separate network. We can see that because of the IP ranges here. The IP subnet on, on the left hand side, subnet A uses a different IP address range to the one on the right hand side. Now the computers within each of these networks can communicate with each other.

But at this point in time, they can't communicate across networks because they're different IP address ranges. If we want to enable that communication, we need to add a router. So the switch is the layer two device, the router is a layer free device, the router can communicate between different IP networks. So if a computer on the left hand side, like this one with 19216802, wants to communicate with a computer on the right hand side with an address like 10 002, then it has to send that communication request to the router which will then forward it on to that other IP network.

So you need a layer free device to forward between different IP networks. A layer two device connects computers on the same IP network. Now the router will have a routing table. This is a really simple one.

They're usually much more complex than this. This router simply knows that the 192168 network is our E zero. That's the Ethernet zero interface and the 10 network is our Ethernet one, that's the other interface. And in the real world routers will have lots of different connections and routing tables which tell the best route to get to a specific network is gonna be at one or another interface.

And so that's how we can connect computers with routers and switches at layer two and layer three. Next, we have the concept of firewalls. Now, firewalls are essentially security devices, they're there to screen the traffic that's coming in and out of our networks to check it and see if it matches what we actually want to allow. Now, a firewall will have a table like this one.

This is the rules, these are the rules that determine what we want to allow or what we want to deny or a combination of the two. So here we can see that we've got protocols, we've got ports, we've got the destination and the source, depending on the type of firewall, it will operate at different layers of the O SI model. It might only understand source and destination ports and IP addresses or it might also understand the protocols like http up at the application layer and be able to inspect the http request to see what information is in there and determine whether it's allowed or not. So there's definitely different types of firewall that support different use cases.

Now, firewalls can also be placed at different layers within the network. We can have them on the perimeter, but then often we'll want to put them internally as well, even attach them directly to our individual servers. Of course, security groups in East two would be an example of that where we can apply a firewall that screens the traffic and determines what's gonna be allowed to reach our EC2 instance. And then network AC LS in a VPC can operate at the subnet level.

So they're the firewalls that are determining what traffic is allowed to enter or leave that particular subnet.


### 39. IP Addressing

In this lesson, we're going to cover IP addressing and I wanna help you to understand what IP addresses are and how they are structured. So we're gonna start off looking at the structure of an I PV four address and I'm gonna concentrate on IP version four. It's still the most widely used IP address range. Version six exists.

That's a concept for another lesson. So firstly, we write an IP address something like this here. We've got one that's 1921680 and then one. So we write them in dotted decimal notation.

So we see it in a decimal number with dots in between these four different numbers. Now each part of the address is a binary octave. Why is that? Well, the reason is we have binary numbers like this where we have either ones or zeros.

Now each of these numbers has a different value depending on where it is. So essentially each part of the IP address is made up of eight ones or zeros eight, meaning an octave. Now how the number is determined in decimal is based on which values have a one assigned to them. OK?

On the left hand side, we have the most significant bit on the right hand side, we have the least significant bit. That means that a one in this position on the left hand side is worth 128. The next one is worth 64 all the way to the right where a one here is actually worth one. Ok.

So what this means, the way that we, you can actually determine an IP address from binary is if these ones were not ones, they were all zeros, then you'd have a zero. On the other hand, if the they were all zeros except this right hand side, which is worth one. OK. So this is a one in binary.

It's worth one in this case, then the number is one on the left hand side. What we have here is 11 and then all zeros. That means these two ones have a value associated with them. It's 128 and 64 add those together, you get 192 and everything else is a zero and then 168 is 100 and 28 plus 32 plus eight.

OK? So that's how we work out binary into decimal. And it's important to understand this and you'll see why in a moment. So in networking, we have the concept with IP addresses of networks and hosts here in blue, I've color coded what we call the network ID 1921680, that is going to be the same address for every single computer on this particular network.

The host ID in orange here has a unique value per individual computer. Now, an I PV four address has the network and host ID. And the way that we can determine what it is is using something called a subnet mask. This is where we need to understand binary.

You'll see this in just a moment. So the subnet mask essentially masks. The components of the IP address that are included in the network ID. 255 means that all of the bits in this portion of the IP address correspond to the network ID.

So if we have three times 255 here, 255255255, that means all three of these in this IP address on the top here, all three octets are the network ID, which means they're gonna be exactly the same for every single computer on the network. Whereas the host ID is not, that's a zero. That means all of those bits are available to assign to the individual computers on the network. So why do we need to know binary?

So the subnet mask is used to define the network and host ID. But the way that we represent it is often by the number of bits. OK. So here we have the network ID, the same one you saw before.

255255255. Now we know that in binary, that's eight ones. So it's 8 1624. So 24 bits.

So the way that we would actually write this out is often in 19 216800 slash 24. So the slash 24 corresponds to the number of bits in the subnet mask. And it tells us which components of this IP address are the network ID. So you'll often see IP address ranges written out in this manner.

And that's why it is very important to understand the binary conversion, a network and subnet mask can also be written in that format. So that's how you're gonna see it mostly. So here as an example, we have a network with several computers on it. You can see that they all have those first three octets the same OK?

1921680. But then they have a unique value for each individual computer in red there 123456 in this case. So that's networks and hosts and IP addresses. So all computers share the same network ID and have a unique host ID.

Now we have some private IP address ranges that we can use and we use these a lot in the cloud. So firstly, we've got the 10 network 10 and then the next free octets are all available for assigning to hosts or we can subdivide using classless inter domain routing another subject for another time. But starting off here with 10, we can then have a lot of hosts or we can subdivide into lots of networks as well. Then we have 172 16 00 through to 172 31 255255.

And lastly 19216800 to 192168255255. Now, these addresses are reserved for private use according to the I ETF RFC 1918. So you'll sometimes see that number referred to. Now, what we can do with these is we can utilize these as in internal IP address ranges.

These are not rable on the internet. We can only use them internally within our networks. But of course, we have a large amount of IP addresses to work with here. So they're really great for assigning to our resources internally.

And then we can find ways to connect some resources externally, either by mapping public IP addresses to them or using things like NAT gateways for network address translation. So one of the concepts you will need to understand which we'll cover in another lesson is how to then subdivide these IP address range or these IP address blocks into different ranges that we can assign to our virtual private clouds in Amazon B PC.


### 40. Amazon Virtual Private Cloud (VPC)

Hey guys, welcome to this lesson in this lesson. I'm gonna cover the Amazon virtual private cloud VPC. So a VPC is created within an Aws region. It's actually a logically isolated portion of the cloud.

So in other words, what you create within that VPC is only visible and accessible from within your account by default, unless you launch resources that you want to be publicly available. So we can isolate it from other customers on AWS. We can isolate it from other VPC S even within our WS account. So within an A VPC, we can create subnets and those are actually mapped to availability zones.

So the availability zones themselves, of course, those are data centers and we can use those availability zones for lots of different VPC S in that region. But the subnets within a VPC are mapped one on one to an availability zone. Now, of course, we can create multiple subnets in each availability zone as well, but a subnet will not span across availability zones. So we create the subnets within an availability zone and then we can launch our resources.

You can launch those into your subnets for internet accessibility. We can then attach internet gateways. If we want to be able to connect outside the VPC to the internet or to other networks within the VPC, there's a router. Now, you don't see this as a device that you actually can create within a VPC.

It's behind the scenes somewhere and the way that we manipulate the router is through the route table. So we define the routes and that's configured in the router behind the scenes. For us, when we create a VPC, we define the Cider block. That's the classless inter domain routing Cider block of IP addresses.

And the, that's the overall address range for the VPC. So the route table is used to configure the VPC router and define how we want to route traffic either within the VPC or outside of the VPC. Now, we can create multiple VPC S within each region. Each VPC will have a different block of addresses that's not actually mandatory, but it's certainly recommended.

We have something called a Cider block. Cider stands for Classless inter domain routing. This is the overall block of addresses that we assign to the VPC. Each Subnet will then have a block of addresses from the Cider block.

It's actually a subset of the addresses from the overall Cider block. So we have our Cider block, which in this case has a 16 bit Subnet mask, then we create our subnets and in this case, I've used 24 bit subnet masks. So I have Subnet 123 and four. On the right hand side, I have another VPC.

It has a different Cider block. It's 10 100 rather than 10 000. Also with a 16 bit Subnet mask. And then I can create my subnets within that Cider block from that overall address block.

So now I have subnets 111213 and 14. So let's just go into that in a little bit more detail. So the Cider block here we have 10 000. It's got a 16 bit subnet mask, that means 10 0 are going to be the same for every network and every computer within this particular Cider block.

However, we can then subdivide. So of course, we represent that as 10 000 slash 16, then we create our subnets. So I've got 1001 0 slash 24. OK?

So now we've taken some of these bits and we're using these for the network id of this particular subnet. And now it has a 24 bit subnet mask. So the VPC subnets will always have a longer subnet mask than the Cider block by taking additional bits from the host portion and assigning them to the network portion by having a longer subnet mask. So now the subnet mask looks like this one.

Then I can create 1002 and 1003 and so on. This is why it's super important to understand IP addressing when you're working with the cloud, especially in VPC because you will need to know how to correctly create the right Cider block and subnets within that Cider block. And make sure in most cases that they're not overlapping with other VPC S cos that can cause problems with some services like VPC peering and AWS transit gateway. Now, last concept I wanna cover quickly here is that there are some services that we say are in the public space of Aws and some that are in the private space of Aws.

So what we mean here is some services are within a VPC and some are not within a VPC. That's basically the crux of it. So here we have EC2 instances, they're always within a V PC R DS. Databases are within a VPC as is the elastic file system here.

Now, other services like Amazon S3 sit outside of the VPC. So we say that that's the public space and they are directly accessible from the internet. So private services can have a public IP address, but they exist within that private space of the VPC. So here, the instance in the public subnet might have a public IP address, whereas the instance in the private subnet won't.

However, both in both cases, they are sitting within a private space where we have full control. Public services have public IP addresses and endpoints. So they're directly accessible from the internet. Now just because a service sits in that public space does not, of course, mean that anyone can access it.

You still need to have the appropriate permissions. And in some cases, you'll need to find a way to authenticate using another service before you're able to access those services. But they do have those public endpoints if you wanna be able to make that uh that service accessible in some way from the public internet. So that's the difference between public and private and for our instances, they're always gonna be in that private space, which means we need to create our VPC S, we need to create our subnets across different availability zones and then launch those resources into our virtual private cloud.


### 41. [HOL] Create a Custom VPC

Welcome to another hands on lesson in this lesson. I'm going to show you how to create a custom Amazon virtual private cloud, a VPC. So what we're gonna create is basically a VPC that looks very much like this. We're gonna do this manually.

Now, there's a couple of ways that you can create a VPC. One is using the VPC and more wizard. I'm gonna show you that first, it will result in a slightly different configuration to this. But I just want to show you because it's a very easy way of creating VPC S.

However, I think it's really important for you to know how to build a VPC manually from scratch because it will help you to understand how things integrate together and how it all works. So after I've shown you the simple wizard way, I will show you how to do it manually. It's still very straightforward and we're gonna create simply a VPC with public and private subnets across two different availability zones and an internet gateway. I'm in the AWS management console.

I'm gonna search for VPC and head over to the VPC console on the VPC console. Here we can go to your VPC S and you'll note that there's already a VPC here. This is the one we've been launching resources into so far. This is known as the default VPC.

In fact, if you go to the various regions that are enabled for your account, you'll find that they all have a default VPC, which is very useful. So we can often just deploy resources straight into the default VPC. However, we will often want to create our own VPC s with our own IP Cider blocks. And that way we can create our own private VPC S which are configured exactly the way we want them to be.

The default VPC has subnets in all of the availability zones for the region. Now this particular the region US East has six availability zones. So we have six subnets and they're all public subnets. That means you will get a public IP address.

If you launch an EC2 instance into one of these subnets, we can see the IP Cider block for each of the subnets, we can see the availability zone, there's also an availability zone ID. Now, the reason for this is because most people tend to launch resources into the US East one A one B, one C and so on. So they kind of start at the beginning of the alphabet. That means Aws would end up with a big problem, everybody putting their resources into those few availability zones.

So instead they randomize this. So us east 18 in your account might be different to mine. Now, this one here, the availability zone id, this is accurate. This is the specific availability zone.

In other words, the specific data center in which your resources will be deployed. So if you need to separate your resources across availability zones in different accounts, this gives you an accurate way of identifying exactly where they're going to be placed. OK? So we're gonna create a custom VPC.

Let's go to your VPC S. I'm gonna click on create VPC and initially, we're gonna switch over to the VPC and more wizard. OK. Here, we can provide a name.

I'm gonna call it my custom VPC. And then on the left hand side, here we have the various options to configure and then it gives us a preview of what thing, what's gonna be created. So we can see there's a Cider block. I'll leave that as it is.

We don't need I PV six. At this point, we can choose the number of availability zones. So maybe I want free. So now it's going to create the subnets across free availability zones.

We can see us East one A one B and one C. How many public subnets do we want? Well, we've got three A Zs. So it makes sense to have three here and then free private subnets, but we might not want public subnets at all.

We might only want private resources in this VPC. So we can just flick the little buttons here and change what, what it is that we want. I'm gonna leave NAT gateway off and I don't need an S3 gateway either. I'll leave DNS host names and DNS resolution on and create the VPC.

And so that creates everything for me very, very quickly, very, very easily. We can see what's going on. It's creating the VPC enabling the DNS settings, creating the subnets, creating an internet gateway, attaching the internet gateway to the B PC. Then there's a route table and an attachment.

And then of course, finally, it's being attached to basically each of the different subnets and we have a route to the internet gateway that's been added as well. So I like the VPC and more wizard. It's a very simple way of doing things uh just to go back and show you again as you go across towards the right hand side. That's where you can see the various route tables and the associations between the different components.

All right. So we've got a custom BBC that was very, very simple. We can go and have a look and we should have some labels in here to identify the, the new subnets. Here we go.

One A one B, one C, one A one B, one C, we've got public and private subnets. So that's been configured for us. Now, one thing to note is if you select a public subnet go to actions and edit subnet settings enable auto assigned public I PV four address is not enabled. OK?

That means that by default, when you launch instances, they're not gonna get a public IP address even though this is a public subnet. So you might wanna change that and turn it on just, just so that you don't miss it during the uh the launch, you can change it in the launch when you're launching an instance. Um But it's better maybe to just set it up at the subnet level here. OK?

I just wanted to show you that one. We're gonna do it manually now. So let's go back up to VPC S and let's delete this VPC and it's just gonna delete everything for us. Nice and easily as long as you haven't launched any resources in there.

Ok. That's done. Now, let's, let's see how we can do the same thing manually. Now, in the course, download in the Amazon VPC directory, you'll find this custom dash VPC dot MD file.

So we're gonna create a VPC called my VPC and this is the Cider block we're going to use. So I'm gonna copy the Cider block. Let's come back, create VPC. This time, I'm choosing the VPC only option, provide the name I PV four sider here and then we're going to create the VPC.

We don't need to change any other settings. It's going to set the tags for us. So we have a name of my VPC. I don't need I PV six.

So let's just create the VPC. OK? That's simple. We've got a VPC.

It doesn't have anything in it at this stage. The next thing we want to do is we want to create subnets. We're gonna create the public and private subnets. So let's just change this public and private.

That's what that should say. All right. So let's copy the name public one. A of course, this will be in the one a availability zone.

Let's come back. Let's go to subnets. Let me just refresh. It's giving me an error just because it can't find those subnets from before.

Let's refresh the page properly. There we go. OK? Create subnets.

Now, I have to select a VPC. So of course, I'm going to select my VPC. We now have the subnet settings here. Let's put in public one, a availability zone will be us east one A.

Then I need to find the Cider block. So let's come back. It's gonna be 1001 0 slash 24 paste that in here for the I PV four Cider block. And now I'm going to add another subnet and I'm just going to repeat the process.

I'll copy the name public one B put that in this one's gonna be 10 20 slash 24. Then we're going to add another subnet. This is gonna be one of the private subnets, private one A let's put that name in and this is gonna be in one A. In fact, I think I missed the, yeah, I missed the availability zone there.

So one B and then we've got one A here. This one's gonna be 10.0 0.3 0.0 slash 24. And then the last one will be the private one B subnet. So let's just copy that name pop that in.

This one will go into us east one B 10 dot Z 0.4 0.0 slash 24. And that's all of my subnets. So now I've got the subnets, they are associated with the VPC. We can see the four subnets we just created right here.

The next thing I want to do is I want to create a route table for my private subnets. Now, if we come back and have a look at route tables and let's just take a note of the B PC ID 102 D is the last few digits. So if we come back here, very easy to identify when I've only got two. But if I select that B PC and in fact, it was code route tables and let's just identify the B PC here and choose the route table.

So there is already a route table. OK? And the subnet associations here, there are no explicit subnet associations. However, all of the subnets in the VPC are implicitly associated with this route table.

But what we wanna do, we wanna have a different route table for our private subnets in case we want to deploy in that gateway. And also because our private subnets should not have a route to an internet gateway, which is what we will end up having in this route table shortly. So what we need to do in route tables, we're gonna create a route table. This one's gonna be called my private RT.

And then we'll make those associations to the private one A and private one B subnets. So we just need to give it a name, select the VPC, create the route table, then go to Subnet associations. We're going to edit explicit subnet associations and choose private one A and private one B and let's save those associations. OK?

So now we have the route table set up correctly. Next, we need to create an internet gateway. So this one's my IGW and of course, that will be associated with our new VPC. So let's come back, go to internet gateways, create an internet gateway, paste the name in and create.

So now that we've created it, we can attach it to a VPC using the actions menu. Let's select the VPC. There's only one available cos the other one already has an internet gateway and attached. OK?

So that's been attached now. But of course, the instances in our public subnets are not going to be able to use it yet because there's no route. So we have to come to route tables and we're gonna choose this one. This is my public route table.

In fact, sometimes I like to label these so I know what they are public RT. So I've got public and private RT. And what I want to do is go to routes and edit routes. I'm going to add a route and this one is gonna be all zeros.

So any destination and then choose internet gateway and select the internet gateway. Ok. So that means everything in this IP S Cider block, the 10 range is going to be routed locally within the VPC and then this basically means everything else. So after you've checked whether the address is within the internal cider range, if it isn't, then send it out to the internet gateway and that will go to the internet.

Ok. So now we have the route table set up. The last thing I wanna do is go and make those changes to the public subnet so that we auto assign public IP addresses. So let's do that public one A and do the same with public one B enable auto assign.

Here we go. All right. Now we have our VPC set up. Let's just go and launch an instance into it just to test, does it have the internet access that it should?

So I'm gonna launch a new EC2 instance, launch instances, Amazon Linux 2023 T two micro. I don't need a key pair for this one. Now, I need to change the VPC. So under network settings, let's click on edit, change the VPC here.

Then I need to choose a subnet. Now, public one B is fine. I could put it in either of the public subnets. If I wanna make sure I get a public address so I can access the internet.

Public one B is fine. Now you'll note the auto assign public IP is enable. That means I will get a public IP. If I hadn't made that change to the subnet settings, it would be set to disable and we could always change it here anyway, manually.

But I prefer it just to be enabled that way if I forget to, if I it's easy to miss that step. So now we don't have that problem. Now, we don't have any security groups in this VPC. So we're gonna create web access my VPC and let's just copy that, paste it into the description.

We have a rule allowing SSH, so we can connect into the instance. That's actually all I need for this particular instance. So let's go ahead and launch and once the instance has launched correctly, I'm gonna use instance, connect to connect to it. The security rule, of course, that we made sure was in there 22 from any source will allow me to do that as long as it has a public IP, which is the other critical piece and it does have a public IP cos obviously it was enabled in the launch wizard, but also so it was automatically enabled because I edited the Subnet settings.

OK? The instance is running, it might be available to connect. I can try and let's see if we can connect, I'm using easy two instance, connect easy two user. And there we go, we are on the command line.

So I'm gonna do a simple ping google.com and we do get a response. So, so I've set up my VPC, I have internet connectivity for my instances in public subnets and they're picking up those addresses automatically. So that's all I wanted to show you for this particular lesson. All I wanna do here is terminate this instance.

I'll leave the VPC. There's no cost to the VPC by the way. So there's no issue with uh being charged when you will be charged is if you create a net gateway. So if you create a net gateway so that you have internet connectivity for the instances in your P private subnets, then there is a free tier but after you go past that you could be charged.

So uh that's something to watch out for. But the VPC, the internet gateway, the subnets, you don't pay for those. So that's all good.


### 42. Security Groups and Network ACLs

In this lesson, I'm going to cover security groups and network AC LS. These are both types of firewall that we can use on AWS to protect our EC2 instances and databases and other services that sit inside an Amazon VPC. Now, firstly, I need to cover the difference between what we call a state full and a stateless firewall. So here we have a web server on the left hand side and a client on the right hand side who wants to access that web service and you can see the IP addresses associated with these two different computers.

So what happens is because it's a web server, it's gonna lessen on port 80. That's the well known port for the unsecured version of http. So the connection goes over at port 80 there's a source port. Now, the source port is dynamically allocated by the operating system of the client and it's a high numbered port.

So it's not one of the well known ports which sits somewhere between uh one and 1024. It's one of the high numbered ports. It's dynamically assigned. So we never know what it's going to be.

But there always has to be a source port and a destination port as well as a source IP and a destination IP. Now the server will receive the traffic and then it's gonna respond. In this case, we swap things around. So the source port becomes a the destination 65188 in this case.

So here we can see these two different traffic flows. OK? The first one, the top one that is coming from the client to the web server. We've got the source IP address, destination IP source port and the destination port.

And then we swap things around for the connection that's going back again. So we can see there are two different connections, but we know that they're actually related. Now a state full firewall will allow that return traffic automatically. So in other words, if there's a rule that allows the inbound traffic to reach the web server on port 80 from this particular client or any client, for example, then any turn traffic that needs to go back to that client is going to be automatically allowed.

In the case of a stateless firewall. These are two completely unrelated traffic flows. Both traffic flows require a separate rule to allow that traffic to pass. So this takes us to security groups and network AC LS.

These are two different types of firewall that we can use in a VPC. Let's get started with the network AC L first network AC L is a network access control list and they're applied at the subnet level, they screen the traffic that comes into the subnet and the traffic that's leaving the subnet. They don't see any traffic that's staying within the subnet between different instances. So Neckles apply at the subnet level and they only apply to traffic entering or exiting the subnet ingress and egress traffic.

Now, security groups on the other hand, are assigned at the instance level. Strictly speaking, they're actually attached to the elastic network interface of the adapters connected to your instance. Security groups can be applied to instances in any subnet. We can see here that security group A and B are applied to instances across different subnets.

Now, back to state full versus stateless. The security group is a state full firewall. That means it will allow return traffic if the inbound traffic is allowed. Network AC LS on the other hand, are stateless firewalls.

So there you have to apply the rules in both directions for inbound traffic and outbound traffic in order for it to work. So let's just compare the two here. Security groups operate at the instance level. Network AC LS operate at the subnet level.

So security groups will filter traffic that's going between instances in the same subnet. Whereas the AC L will not do that. Security groups only support allow rules that means everything is denied. And then you have to create allow rules for the traffic that you do want to allow.

On the other hand, network AC L taught both allow and deny rules. So you can have a series of allow rules and then a deny rule that says everything else is denied. For example, the security group is state full and the network AC L is stateless. Security groups evaluate all rules to see if there is an allow for the specific traffic.

Whereas the network AC L processes the rules in order. So they're actually in a numbered order. And when it reaches a rule that either allows or denies the traffic, it just stops the processing right there. It either allows or denies the traffic at that point, regardless of whatever rules might come after that particular rule.

Security groups apply to instances if they're associated with the security group. Whereas network AC LS basically apply to every instance in the subnet that they're associated with.


### 43. [HOL] Using Security Groups and NACLs

Hey guys in this lesson, I'm gonna show you how to use security groups and network access control lists or knuckles. I'm in the EC2 management console and I'm gonna head down to security groups and I'm gonna create a security group called SG one. So we've got SG one, I'll put the same in the description and I'm simply going to add a rule for SSH for management purposes from anywhere. And this is in my default B PC.

Now, the outbound rule will allow the initiation of traffic outbound. This is a state full firewall. So a security group will allow the response to any traffic that comes inbound. So in fact, I can ssh to this instance, even if I delete the outbound rule, let's try that.

Let's remove the outbound rule. And for inbound rules, we'll just leave SSH from anywhere and create the security group. So now I'm gonna launch an instance. This is all in my default VPC.

So we'll call this one instance one and it's come down. I don't need a key pair cos I'm gonna use instant connect, select a security group. I'm going to choose SG one and that's all I need to do, launch the instance. And then once the instance is running, I'm gonna connect to it using instance connect.

And we're going to test what we can do. The instant is running. Let's select the instance and choose connect. And let's see if we can connect using the E two user.

So that's worked. I am now connected to the instance because I have the rule allowing the inbound traffic. So that's not been a problem of now, of course, there is two way traffic happening here between the instance, connect and the instance itself within my VPs. But the return traffic is being allowed.

Now, what if I try to do the Ping google.com? Now it's not gonna work. Ok? I cannot do that because it's not gonna allow that traffic outbound.

So let's go back to security groups and select SG one and then go to outbound rules, edit and let's add a rule and this one is gonna be IC MP I PV four to any I PV four address. Let's save that. Let's come back and see. Now we can pin google.com.

Ok? So the only rule that I can, uh the only traffic that I can initiate outbound is going to be to google.com. If I try to curl google.com, this is gonna use, I've gotta put http colon slash slash, that's not gonna work. It's just gonna hang.

Ok? It's not actually completing and that's because I'm not allowing http outbound So now what I need to do is edit inbound rules and uh outbound rules and add http to anywhere. Let's come back and see if we can curl. OK?

Now we get a response. OK. Uh So we are actually able to use the HTTP protocol. So remember when you're initiating outbound connections, you need to have rules.

Typically we have that rule in there, the default rule which allows all traffic. OK? So it's all traffic here. It is to any destination.

OK? So that means I, I can now initiate all outbound connections. However, this particular server is now only allowing inbound connections on port 22. So let's test this out.

I'm gonna go and we're just going to run this. This is the user data, simple website. Now, I didn't add this at launch. But what I'm gonna do instead is I'll show you how to just turn this into a simple script.

I'm gonna change to pseudo so that I've got some more permissions. And what we're going to do is uh Nano, a shell script. So let's call it user data dot sh paste this in. I'm gonna save it using Nano.

So now I have this file and what I want to do is ch board plus X file name to make it executable and then we're gonna run dot slash user data dot sh. OK? So that should it, it's gonna update the Linux um patches, then it's going to install Apache and we should have a website. There we go.

That's done. OK. So let's just clear the screen. So what I should be able to do is change to va dub, dub, dub html.

And oh, in fact, the new, what happens with the latest version of Apache, there's no actual index to html. Here. It's part of the configuration of the web server, but it will show me an, it works message if I connect to this website. However, in this case, it won't work.

And that's because we don't have a security group rule. So of course, if I come back, select the public IP and then let's go to browser window and it's just hanging again. Sure. Sign that it's a security group issue.

If the connection doesn't complete, it doesn't error, it's just kind of not going anywhere. All right. So of course, what we need to do for that is come back to security groups, choose SG one edit inbound rules, add a rule. And for this, it's gonna be http from any source address.

OK. Now, I just stop that. Let's try it again. Now it works.

OK? So we've not, we've got that message from Apache. So that's all working. Great.

Now, let's bring another instance into the mix and we're gonna have a separate security group. So we're gonna have the SG two security group. And what we're going to do here is we're not gonna allow any inbound rules in the beginning. Let's just create the security group and let's launch an instance and this one is going to be also.

Well, in fact, I'll call this one instance two so we can identify it nice and easily and scroll down with the defaults left in place. Proceed about to keep a default VPC. I'm gonna select SG two and then launch what I want to do now is for instance two, I'm gonna copy its private IP address and from the console of, of instance one here, let's just um change back to our root directory just to clear things up a bit. And what I'm gonna do is ping that instance.

Now, you know that I'm allowing outbound traffic, I can ping google.com, but of course, there's no rule on the other end. So what we wanna do is I'm gonna do this the most secure way possible. I don't really want everyone on the internet to ping my instance or to be able to, what I want is for instances in SG one security group to be able to ping the instance. So the way I'm gonna do that is to come to the SG two security group and I'm gonna add an inbound rule.

So on inbound rules, edit, add a rule and it's going to be IC MP I PV four and this time I'm gonna type SG and we can see security groups. So I'm gonna choose SG one. So what I'm doing now is I'm allowing inbound traffic on IC MP I PV four protocol from members of this security group only. OK.

So we've locked it down, let's rerun that pin command and now it works fine. So we call the security group chaining. We essentially set the inbound traffic to be allowed only from another security group. We can do the same with outbound traffic as well.

So for example, I could lock down the security group one to only be able to send to security group two. In this rule, I'd have to delete that outbound rule add in one for IC MP and set the destination to the security group. So security group chaining very useful feature. OK?

That all looks good. Let's switch sites to using network access control lists for this. We're gonna head over to the VPC management console and under security here, we've got network AC LS as well as security groups. So let's have a look at what we've got here.

We've got this one with six subnets. That's the one in my default VPC. So here we can see that we have inbound rules. The rules of knuckles are in a numbered order.

OK? So rule number 100 in this case is the only rule, then there's a star which is kind of like a wild card at the end of the set of rules. Now, the first matching rule applies. In this case, all traffic from all protocols, all ports to and all sources will be allowed.

So the deny doesn't really take effect at all. So what we can do is we can add rules with different numbers. Let's add rule 101, which says that all traffic from any source is denied. And what do you think that's gonna do?

Can I still refresh the page to this web server? It's refreshing. It's fine. It's working.

It's not a problem is instance, connect, still working. Yep. Not a problem. So of course, because of the numbered order 101 is not being processed because the match is happening at rule 100.

So what happens if I change that rule to 99? Now the order flips now 99 is first. What's gonna happen when I refresh this page? It's gone.

What about instance connects I'm pressing enter, nothing's happening. OK? It's all dead now. So I've just, I've just restricted access completely.

So that's the way that knack call work. Otherwise, they're very similar. In the case of we have to set the traffic that we want, which protocols which ports the source and the destinations. There's no security groups here for sources.

It is IP S that you're going to utilize. Um So you have the option of just adding in the IP here as an open range or something more specific right down to an individual IP address. So for example, you can have a deny rule for a specific IP address. Let's just assume this is a valid IP address on the internet slash 32.

That's an individual IP address all 32 bits of masks. So that would be a match for that particular computer on the internet. So that's how you can use network AC LS. Now remember that these are stateless.

OK. So you need to have a rule for both directions. So I've just removed the rule that I added before and let's go and have a look at outbound. So outbound, basically the same as inbound.

It's allowing everything at the moment. So it's allowing all inbound connections and all outbound connections. Remember that if you add a rule allowing a protocol inbound, you have to make sure that is allowed outbound. It is in this case by default.

But if you remove this rule 100 you're gonna break everything because you must be allow the traffic that goes outbound. That's even if it's in relation to inbound traffic, it's the response traffic from an inbound connection doesn't matter. The network AC L treats it separately. OK?

So that's a quick overview of network AC LS and security groups and all I need to do now to clean up this lab is simply terminate these two instances.


### 44. Cloud Computing Deployment Models

Welcome back in this lesson. I'm going to cover cloud computing deployment models. So deployment models are different to service models. The service models are infrastructure as a service platform, as a service and software as a service and then some variations of those different models.

Now we're talking about deployment. So we're talking about private cloud, public cloud hybrid and you can see the different options here. So private cloud is where you deploying the infrastructure in your own data center and then you have to have the relevant software layers on top to make it a cloud service, things like the metered billing as well as the service catalog. So we can build these a variety of ways.

There's uh different vendors who offer the software layers to sit on top of the hardware and they include vmware, Microsoft hat and open stack. And then of course, we've got the public cloud. That's mostly what we've been concerned with. In this course, we're talking about AWS, but other ones are Microsoft, Azure and Google cloud platform.

Those are the three biggest, there are others, of course as well. Now, hybrid cloud is just where we're connecting our clouds together public and private and multi cloud is where we're using two or more of these different offerings at a time. So let's have a look visually. So private cloud is where we've built our infrastructure layer.

We've got our virtualization clusters, we've got our storage and backup systems. We've got our networking and communication devices and potentially some firewalls in there as well. So we're gonna build and manage this cloud deployment in our data center. And then we need to layer on top of this some capabilities through software.

So here we have a service catalog and a self service portal. We've got some configuration management, billing and reporting and multi tenancy and there's other components as well. We need to provide those capabilities on top of the infrastructure layer in order to make this a true private cloud benefits here are that we get complete control of the entire stack. We can build it exactly to our requirements.

Security can be a benefit here. Now, the public cloud has a huge amount of security built into it. In fact, it's very hard to replicate the levels of security that AWS implement. However, in some cases, you might need to have full control of every layer of the stack.

And the only way you can do that is in your own data center. So there are some situations where security is a benefit when we're looking at private cloud as compared to the public cloud. So we've got examples like running VMWARE, they have their V cloud suite. We've got Microsoft with Hyper V and the various layers of software you can place on top and Red Hat and open also provides some cloud management software.

So then we have the public cloud. So the public cloud is a cloud service where of course multiple customers, multiple organizations are utilizing this and anyone really can sign up and start using the public cloud. Now, we might be using it across the internet directly. We might be connecting our corporate office uh either through the internet like a virtual private network connection or a private link.

Now, if we do that, it becomes a hybrid cloud, if we provide that sort of connectivity at the network layer from our office or data center into the public cloud, especially if we're deploying some infrastructure locally in the data center as well and providing that cross communication. Now, in the public cloud, we can deploy various services. Of course, it's 100 loads of different services in the public cloud. In terms of benefits with the public cloud, we have that variable expense.

So it's an Opex an operational expenditure rather than a capital expenditure or Capex cost rather than spending large quantities of cash building our own systems. We're just spending on a monthly basis based on what we use and then we have economies of scale. So the public cloud can be very cost effective. The fact that Aws has created such a large infrastructure and created the software capabilities and the services which so many customers can use means that they can lower the price to you.

Doesn't mean it's always cheaper. In some cases, using a private cloud can be cheaper for certain applications and certain and workloads. But don't forget to factor in all the operational costs, the security, the data center and all those sorts of aspects as well. And then we have massive amounts of elasticity in the public cloud.

It's almost limitless. If you scale your business really quickly, there's capacity there for you very hard to replicate that if not impossible in a private cloud situation. So here, of course, we have Aws Azure, Google cloud platform and other providers as well. So the hybrid is what we saw before, but where we're actually connecting our data center and the cloud.

So not just the people in the office, but we now actually have the full data center and whatever applications we have in our data center on premises connected into the public cloud with a connection which again can be a virtual private network over the internet or it can be a private link like AWS direct connect. So here we can choose where to put our applications. Some might make sense in the data center, some might make more sense in the public cloud. And we can leverage different services for our various applications as well like SAS services or platform as a service or IAS in the cloud.

Maybe we even just use it as a burst capacity or a backup. That's what some organizations do. We can also easily move data and applications and services between these different deployment models because we've set up this connectivity between them as well. Lastly, we have multi cloud, this is becoming a lot more common.

All this really means is that a company is finding the need to leverage multiple public and private cloud services. They might find that some applications they prefer to deploy into Azure. Maybe that's because one of the development teams and part of the company are more interested in.net and they like to use powershell and they're used to the Microsoft stack or maybe you just prefer the identity features and integration into office 365. For example, other applications might make more sense in the Aws cloud.

So they put some in there as well and then they might even have multiple private clouds built on vmware, openstack and other providers. And they've got full connectivity between these different clouds. That's a multi cloud environment. And it means you get the best of these different clouds, of course, that does increase complexity.

So it's not always the best for things like security or operational efficiency, but it is quite a common scenario today.


### 45. AWS VPN and AWS Direct Connect

In this lesson, I'm gonna cover virtual private networks and Aws direct Connect. So we often wanna connect our corporate data centers or offices with the Aws cloud. And of course, there's a couple of ways to do this. One is what's called a site to site VPN, a virtual private network.

The other is direct connect. So we're gonna have a look at those two in this particular lesson and see what the difference is, are. So here we have an on premises network on the right hand side, the corporate data center and that's got its own Cider block. And then on the left hand side, we have a VPC.

So a VPN is a managed IPCC virtual private network. Now you can create your own software based VPN S. But what we're talking about here is an AWS managed VPN. So that's a service provided by AWS and it uses I PE for encryption.

Now with a VPN, we have something called a virtual private gateway, which is on the VPC side. So that's a component that we create within our VPC. So it's deployed in the VPC on Aws side. Then we have the customer gateway essentially, this is a component of configuration if you like that, we create within our VPC.

But the actual device itself is of course in the corporate data center. So we just have to create some configuration for it in the VPC on the AWS side. But the actual physical device is in the corporate data center and needs to be configured by the local admins there. So that's on the customer side with these two components, we can then create this encrypted VPN connection over the public internet doesn't have to be over the public internet.

By the way, for example, you can create an encrypted connection over the top of a direct connect connection as well. But in this case, let's just assume this is across the public internet. Now, this does support static routes and B GP pairing and routing. So if you're a network admin that's gonna make a lot of sense to you.

Um We can configure various options for how we propagate routes and configure the routing behavior between the on premises data center and the VPC. Now, in the VPC, of course, we need to have a route table configuration if we want to be able to route from the VPC to the on premises network. So in this case, we can see that this private subnet here has a destination of the Cyder block of the corporate data center. And the target is gonna be the virtual gateway ID.

That's the virtual private gateway, that's now gonna allow that outbound connectivity from that private subnet to the corporate data center. Next, we have direct connect. So again, we have the AWS cloud, we have a region and a VPC here and a corporate data center. Now, in between those, we have something called an AWS direct connect location.

Now you'll want to find one of these that's relatively close to where your corporate data center is because you then need to create a connection to that location within the direct connect location. There's going to be an Aws cage. So that's essentially just a a cage that has the AWS devices in it within the data center. And then there's the customer partner cage.

So the customer or partner router is gonna be on the right hand side there. And of course, the Aws router is in the Aws cage. So what needs to happen to establish connectivity. Firstly, what we need to do is get AD X port assigned in the DX location.

Ok. So DX for direct connect. So that means that when we go in and order a connection from Aws, they are going to provide some information to us. And that information is going to include the port within the DX location that we need to connect to.

Then if we have a presence in that location, we can ask the data center to patch a wire across between our equipment and the Aws equipment. Or alternatively, you use a partner. So you use a managed service provider who do have equipment in that location and they're gonna patch between their equipment and yours. Then you need to make sure that you can connect from your customer router in your data center through to the DX location.

So there again, you're probably gonna need to speak to a managed service provider to create that connectivity for you. So now we have the cross connect between the two different cages in the DX location and then the private connection from the data center into that DX location. AWS take care, then of establishing the remaining configuration through to the actual VPC itself. A direct connect connection is a physical fiber connection to AWS running at one gigabits per second to 100 gigabits per second.

Now, you can get lower speed connections from partners as well. So what are the benefits while you're getting enhanced security? You're using private connectivity into AWS, you get consistent network performance, better speed, better latency and bandwidth and throughput. And then we have lower costs.

Now, it's not always lower cost. It really depends on the volume of data and the level of redundancy that you need. In some cases, if you have business critical applications and data traversing across this DX connection, you're gonna want to implement multiple DX connections with redundancy throughout and that's gonna get quite expensive. However, if you are transferring large quantities of data, you'll need to do the calculations and have a look at that compared to utilizing internet links and see if it comes out as being cost effective.


---

## Part 6: AWS Storage Services


### 46. Introduction

Hey guys and welcome to this section on AWS storage services. In this section, you'll learn about a few really important services on Aws for storage. And there are some fundamental concepts you need to understand about storage, technology, block based, and file-based and object based storage. So before we get started and looking at the various services that provide access to our data using those different mechanisms, I'm gonna give you an overview of what that actually means.

So you understand what is a block based storage system? What is a file-based storage system? What is a object based storage system? So then we'll look at the Amazon Elastic block store, the Amazon Elastic file system and the Amazon Simple storage service.

Amazon S3.


### 47. Block vs File vs Object Storage

Hey guys in this lesson, I'm going to cover the differences between three different types of storage system. We've got block based storage systems, file-based storage systems and object based storage systems. So I wanna clarify what the differences are between these because we're then gonna be going into some detail about different services in AWS that correspond to this different type of storage. Now, if you're come coming from an on premises background, you've got some experience in it and technology that you're probably familiar with block based and file-based storage, but object possibly less because it's usually more in the cloud that we use object based storage system, not only there, but that's traditionally been the case at least.

Uh And if you're completely new to it, then probably none of this makes sense. So let's clear things up. So firstly, block based storage, what we're talking about here is essentially hard drive. So hard drives are block based storage system.

So you can see the old fashioned hard disk drives on the left with a spinning platter looks a bit like one of those old record players. And then we've got a solid state drive on the right, which is more like a chip. So there's no moving parts in the SSD and they're much, much faster. However, we still use the HD DS, the hard disk drives on the left quite a lot in the cloud.

And they are very cost effective and they're still good for some use cases. Those are known as magnetic drives. Cos they use magnetism actually polarize uh the bits on the, on the platter there, that sort of spinning disk um into, you know, different directions to indicate whether it's a one or a zero. So much, much older technology and much slower than SSD, but also much cheaper than SS SDS SD uses flash memory.

So it's more like a chip without those moving parts. You see on the left, much newer technology still been around quite a long time and it's a hell of a lot faster than solid state drives thousands of times faster in many cases. And also more expensive. Of course, you pay more, but you get better performance.

So with block based storage systems, which hard disk drives are in our computers, what we actually see is a disk. So on Windows, if you go into the disk management console, you'll actually see a physical disk being represented there and we then create volumes. So we've got the hard disk drive, it's essentially the same as one inside your computer here. This is a disk in a Windows computer.

We've got the disk management console. And we've got the volume that's being seen by the disk management console. So what we can do then is we can partition that drive. So we, we initiate that volume.

I think in windows typically with a new volume, you have to activate it and then you have to create a volume and then you can partition the volume and use a file system. So here we partition and we've got AC drive and ad drive with different capacities with file-based storage, things are a little bit different. So here essentially somewhere there is a block based storage system that a file system has been created on top, like with windows, you've got NTFS for example. However, it's being shared across the network.

So here you can see we've got a network attached storage server and there's a network. And here on the left hand side is a client computer. Now, the client computer already has block based storage systems internally within that system and they're being represented by C and D drive in this case. OK?

And the network attached storage server also has disk drives in it. And what happens on the network attached storage server also called a NAS server is that we then format and we create our partitions and our volumes and, and then we share the file system over the network. OK? So the file system gets shared and can then be mounted on the client computer.

So here we now have a Z drive, it looks a little bit different because you can see that it's connected to a share on a server called ABC. Well, that's what this is telling us here. So we know it's not a local disk in the computer. It's a remote drive somewhere else.

It's a file system being shared across a network. However, the operating system on the computer can interact with it exactly the same way it does with those file systems like the C and the D drive that are inside the computer itself and the connection is maintained between the NAS server and the client. So the operating system here sees a file system that is mapped to a local drive letter object based storage systems are very, very different. OK?

So here we have a storage container in Amazon S3. That's the object based storage system on AWS. It's called a bucket. The user uploads objects using a web browser in this case or it could be an application that is performing these requests using an API.

So here the protocol is actually http. So the same language we use on the internet is the language that is spoken to speak to an objects based storage system using a rest API. So an application programming interface and we're using the methods from http, we're using get put post select delete. So in this case, uploading an object would be a put or a post.

So that's uploading the object using the language of HTTP and then you can add lots and lots of objects to a bucket. Now, the objects are basically files. OK? So any type of file, videos, images, word documents, PDF S doesn't matter.

Aws S3 will support all file types. There's no hierarchy of objects in the container. It's just like a bucket full of sand. There's no hierarchy for those Granules of sand in there.

They're all just thrown together. We can mimic some kind of hierarchy. I'll get, get to that when we get to Amazon is free. So here side by side, we've got block based storage system.

This is basically the hard drive, the OS reads and writes at the block level and the discs can be internal or they can be network attached. So you can actually attach those over a network that with some sort of specialized protocols like I cuzzy and fiber channel over Ethernet or fiber channel itself over a dedicated network for storage traffic. So here the OS sees volumes that can be partitioned and formatted. OK?

It's the only system here, the only type of storage system in which you can see a volume and then partition it and choose the file system. Choose how you segregate that data. Then we have file-based storage here. The file system is mounted over a network using from a network share and the file system can be mounted by many different users.

So hundreds of computers, thousands of computers they can all mount that same shared file system and they can all read and write data to it. Now, the reason why we love object storage in the cloud is because of the rest API and the scalability. And the cost, the API means we could easily write code that can upload, download, delete, work with those objects, those files in the object based story system. So very easy for developers to integrate into object storage.

Also that huge scalability and extremely low cost means the object based storage is great for lots of different use cases from log files through to data storage and backup and many many more.


### 48. Amazon EBS and Instance Stores

Hey guys in this lesson, I'm gonna cover the Amazon Elastic block store and instant stores. So firstly, let's get start off with the elastic block store. So you might have guessed this is the block based storage system on Aws. So it's known as Amazon EBS.

So with EBS, we have volumes here, we can see that within this availability zone, we have a couple of volumes and we have an instance that's connected to them. So here on the operating system of that instance, we can see see two different drives. We've got the C drive and the D drive. Now they appear to be local disks.

And that's because as far as the operating system is concerned, they actually are, however, they are in reality connected across the network. So it is a network system, but it's a block based storage system, not a file-based storage system. So here we have C and D drive. Now, the volume's attached over the network and the volumes exist within an availability zone.

Ok. So you won't be able to connect to these volumes. If your instance is in a different availability zone, the volume gets automatically replicated within the availability zone. So to give you a slightly different view of it, here we have an example of one individual host server in the AWS data center.

Cos remember EC2 is basically a virtualization platform. So we have a host server um you know, which is one of many in an AWS data center and then many instances will run as virtual machines on top of that host server. So here we have several instances and of course, there's physical adapters connected to that host server. And then the EBS volumes are a storage system that's then mounted across the network.

Now, we also have those disks that you can see here within the host server. What are these ones? Well, these are instant store volumes and they're physically attached to the host itself. They offer really high performance really, they're like chips, they're you know, like some, some type of flash device.

So very high performance EBS volumes are over the network, instant stores are within the host server. Now, really important difference between the two here, instant store volumes are ephemeral. That means the data is non persistent. If the power is lost to this host server, all that data is gone forever.

Ebs volumes offer persistent storage. OK. So if you have long term data storage or you cannot afford to potentially lose your data, it has to go into an EBS volume, not an instant store, instant stores can be useful though. So you might use it for some kind of temporary data that can be recreated.

OK. In that use case, not a problem. Now, how do we take backups of our EBS volumes? Well, we use something called a snapshot.

Here. We have an instance in availability zone A, it has an EBS volume attached which of course is in the same A Z, it must be, we can then take a snapshot that is a point in time state of the instance or of the volume. It's basically let's take a copy of the volume, the data on that volume exactly as it is at this particular point in time. And it goes to a snapshot.

Now notice that the snapshot is not in the availability zone because it's actually on Amazon S3, S3 is a regional service. So the snapshots stored on S3 and we can take multiple snapshots and they're incremental. So we're only backing up the differences in those subsequent snapshots. Now, somehow with the magic of aws, they manage it so that you can actually delete the older snapshots and you only ever need to keep one of them the most recent one.

If that's the only data that you need, if you don't have to go back to different points in time. So what we can do then is, for example, we might wanna take that snapshot and create a volume from it. That volume could be in the same A Z or it could be in a different A Z cos S3 of course is regional. So now we can actually move data between availability zones through snapshots.

We create a snapshot goes into S3 in the region and then we take the snapshot, create a volume in a different A Z. Then we could essentially attach that to an easy two instance. And it would see the same data, you can also create an Ami from a snapshot. So AMI S are always backed by a snapshot.

So I've customized my 82 instance, I've taken a snapshot and then I can create an AMI that backs onto that snapshot. And then new instances can be launched automatically in any availability zone within that region.


### 49. [HOL] Create and Attach an EBS Volume

Hey guys. In this lesson, we're going to work with EBS volumes. We're gonna launch a couple of instances and we're gonna create some additional data volumes and see how we can move that volume between instances. For this lesson, there are some instructions in a markdown file in the course.

Download last lesson of section one. That's where you can find the course download, then you extract it, go into the EBS, Amazon EBS folder and here you'll find this file, Amazon EBS volumes. So first thing we need to do is launch an instance in US S one A and one in us S one B. So back in the console, let's launch instances and the first one is going to be in us S one A.

So I'm gonna call this one A and just so I can identify easily. And let's go to proceed without a key pair. Choose edit for network settings, default VPC. And my preference for the subnet is US S one A enable auto assign public IP, select a security group.

Let's just choose the web access security group and we're gonna launch that instance, then let's do the same and we're gonna launch one in us East one B. So this one, I will call one B, proceed about a key pair again, just change the subnet to us East one B and select the web access security group and then launch, that's all we need to do. So that gives us the two instances across two different availability zones. Let's just refresh the page so I can see the two.

Here we go. Let's organize them one A one B those are initializing. Now, what I want to do is create an additional data volume. So what we do on the left hand side under elastic block store, I'm gonna head down to volumes.

We can already see two volumes. Now, these volumes are in use and they're in us. S one A one B, these are the root volumes for our instances. OK?

And we can see the volume I DS. We can see that they came from a snapshot. That's the Ami that's the Amazon machine image snapshot, which they were launched from. So it's a bit of information there.

These ones are not encrypted. We can always enable encryption if we wish to. And in that case, we would have a K MS key attached. That's the key management service.

What we're going to do is create an additional volume. Now, I want to attach this volume to my server in us east one A. So I have to make sure I choose the right availability zone actually, that's already selected for me. So that's good.

I need to choose the volume type. There's a whole variety of different volume types. We've got the older GP two. The default is now GP free.

These are solid state drives very high performance. Now there's also the provisioned iops IO one and then the more recent IO two, if you choose those, you can actually specify the amount of iops that you want to drive. So that's the input output per second. Essentially the performance for the disc cold is the old hard disk drive as is throughput optimized HDD and then magnetic, very, very old ones.

These, we don't use these too often. There are a few use cases where you might use them. But today, I'm gonna stick with GP three. I don't need 100 gigabytes.

That seems to be a lot. So let's just put it at 10 gigabytes. I'll leave the default for iops, which you can specify here as well and we've got throughput as well. So I'm just gonna leave those as the defaults.

So I don't wanna change any performance characteristics. Us E one A is good and let's simply create the volume. We can see the volume is in the creating state and it shouldn't take too long before it's complete while that's happening. We're going to go back to instances and I'm going to connect to the instance in US East one A using instance, connect and we're gonna run this command pseudo LSBLK dash E seven.

This is going to list the non loop back block devices on the instance. So I just wanna see what's there? What are the discs we've got XVD A then XVD A 1127128. Now, what we're going to do is attach our volume and rerun that command.

So hopefully we'll be able to see the volume. So let's go back to volumes. Give this a refresh should be ready. There it is.

It's available. Select the volume, go to actions, attach volume. Now, the only instance we're gonna see is the one in us east one A because you can't attach a volume to an instance in a different A Z. So we'll select the instance, it suggests a device name.

I'm just gonna leave the default and then attach. Now let's come back and rerun that command. We can see that we now have a different disk. It's a 10 gigabyte disk.

So that's the one that we just attached. That's the new volume. If we come back to the instructions, we've just performed these instructions here. What we need to do now, we have a disk but we haven't got a file system on that disc.

So we're gonna run a series of commands. We're gonna make the file system type ext four on DEV XVDF. And then we're gonna create a mount point and we're gonna mount the volume to the mount point. And then we're gonna make it persistent.

OK? So let's go and do these things. So firstly, we're going to, so firstly, we'll run this command to make the file system that's done. Next, we're gonna make a directory slash data.

There we go. We've got slash data. So if ILS slash, we can now see that we have the data directory right here. OK?

So the way that you mount a volume to Linux is through a mount point. OK? It's not like windows where you have a drive letter like C or D. So what we then do is we mount the disk to the mount point.

OK. So we take this disk, which this is the one that we just saw was added, that's the U BS volume and we attach it to this directory. OK? So pseudo mount, let's run that command that's done.

And now we're gonna make the val volume mount persistent. OK? So we want to use the nano utility or you can use V or whatever you wanna use to edit this file. OK?

So we're going to open this file FS tab and then it's gonna tell us here, add this information and then save the file. OK? So we wanna have a new line here and then I'm gonna save the file control XY. Done.

OK? So now if I cap the etcfs tab, I should see my entry and it's there. So now that we've done this, we should be able to change to slash data. And of course, there's nothing in here if I run LS.

So what I wanna do is let's just create some data. It doesn't really matter. Test file dot txt. Uh We need to run pseudo for that.

So let's just, we don't have the permissions. That's fine. Test file and I missed a touch command. So let's pop that back in there.

Here we go pseudo touch test file. So now we've got a file, let's do pseudo make directory, my folder. OK? So just a couple of bits, we don't need much data, just something to prove that when we move it to another instance, we should see the same data.

OK? So now we have the data on the drive. The drive is actually mounted to our Linux instance. What I'm gonna do next is go and take a snapshot.

OK? So we're gonna come back to volumes. I'm gonna select this volume and by the way, I was supposed to add a name, you can always add that later on. So it's supposed to be called data volume just for easier recognition.

I'll add that now. So what I can do is actions and then we're going to take a snapshot. So create snapshot. I just call this data snap and create the snapshot and that shouldn't take too long.

We can come down to the snapshots page here, we can see it's pending. Give it a couple of minutes that will be ready. Now remember that the snapshots are not stored in the availability zone, like the UPS volumes, they're stored on Amazon S3 N S3 is a regional service. So they're available within the North Virginia region and they're available to be used from any availability zone.

So once we have a snapshot, we should be able to create a new volume from the snapshot in us, East one B and that's where our other instance is, then we can attach the volume there and we should be able to see the same data. So that's what we're gonna try. OK. Here we go.

My snapshot is complete. Didn't take long. I'm gonna select the snapshot and let's create a volume from the snapshot using the actions menu and it's gonna be the same GP free 10 gigabytes this time it's gonna be in us East One B. OK?

You could enable encryption now if you wanted to and choose a key and let's create the volume. So what we'll have now, we'll see a new volume being created. Let's just make sure that we can see everything here. Yep.

So we have a new volume created in a different availability zone. OK? So here it is, it's available in US S one B that was very quick. Let's check if it's there and ready to use.

What we wanna do is attach the volume and this time it should show the one B server, attach the volume. And now let's go to instance connect. So we're gonna select the one B server connect to the one B server. Let's run that pseudo command again with the S LSBLK dash E seven.

Same thing. We've got that 10 gig dis available. So now we wanna do what we did before, which is, we're just gonna come back. We don't need to make a file system.

All we need to do is mount the disk. So we're gonna make that directory again. We're gonna run mount change to slash data and there's our data. So now we've moved that data between different availability zones.

It's now attached to a different instance. If you wanted to make this persistent, you would also need to add this line here into your FS tab file. That just means that when you reboot the instance, it's still gonna have the volume mounted to slash data. I'm not gonna do that right now.

Cos I've finished with this exercise, just wanted to show you how to create additional EBS volumes, create snapshots and mount those volumes to your E two instances. So I finished with these two instances. So I'm going to terminate them and then I'm gonna show you where to go and clean up the other pieces as well. So those are shutting down.

Now, the volumes that are attached to the root of the, of each of those systems will be removed automatically, the data volume will not. And the snapshot won't. So we actually have to go to the snapshot and delete the snapshot and then we're gonna delete the additional volumes here. Now, what I'm gonna do is just wait.

So now we can see that I've refreshed, the other two volumes have gone, which hopefully means that these ones are available to delete because if they're still attached, then you have to force to attach them. So now the instances have gone, the volumes are available for deletion and we're gonna permanently delete that data.


### 51. Amazon Elastic File System (EFS)

Hey guys. In this lesson, I'm gonna cover the Amazon elastic file system. EFS. So EFS is a shared file system.

We can connect instances to EFS file systems from multiple availability zones. Here we have what's called a regional file system. That's one of the deployment options of EFS. A regional file system has mount targets in multiple availability zones.

So they appear here as an elastic network interface. Essentially, they are an interface into that file system. Now the instances can then mount to that target endpoint within the uh the same availability zone that they're actually in. So instances will connect to the mount point in the local availability zone.

Now, the connection protocol here is the network file system NFS. This is Linux only. OK. So Efs is Linux only, you can use NFS.

Of course, the protocol with other operating systems like windows. But what I'm talking about is the Amazon EFS file system is a Linux only file system from AWS S perspective. So they only support Linux. Now EFS supports Linux only.

As I mentioned, there's another deployment option for EFS that is where we deploy it just inside a single availability zone. We call this a one zone file system. And here it only has a mount target in that single availability zone. Now, it is possible however, to connect across from a different availability zone to that particular target.

So you can connect to mount points in different A Zs if you need to. So that's a bit of a diagram. Let's go into some data in terms of data consistency, right. Operations for regional file systems are durably stored across availability zones.

So there's lots of copies of the data through the NFS V four protocol. It does implement file locking for read and write operations to try and consistency. Now there are different options for storage classes. So you can choose from one of these, you've got EFS standard which does use solid state drives for low latency performance.

You then have the EFS infrequent access, which is a more cost effective option if you don't need to access the data regularly. And then you've got EFS archive, which is an even lower cost if you really don't need to access the data very much at all. Like let's say once or twice a year. Lastly for durability, all storage classes do offer 11 nines of durability just like S3.

So really high levels there, very unlikely you're gonna lose your data. Let's cover some more about deployment options with EFS. So here in this diagram, we have an EFS file system in one region and what we're gonna do is create a replica of that file system in a second region. OK?

So you can replicate your file system for disaster recovery purposes. Now, it is possible then to mount to the amount point locally within that second region. However, it is read only. So until you fail over to that copy of the data, it's gonna be a read only copy.

But if you wanna read from that data for some reason in that region, that's perfectly OK. But you have to create that mount point, it's not actually deployed by default. Now, another way that you can connect to EFS is from outside side of the cloud, so you can connect on premises clients. So again, they need to be Linux based and they need to use the NFS protocol and typically you're gonna use a VPN or a direct connect connection for EFS replication data is replicated across regions.

This is for DR purposes and it does have an RPO and RT O in the minutes. So pretty good, there's also automatic backup. So EFS does integrate with the AWS backup service for automatic files and backups. Now, in terms of performance, there are a couple of options.

So first we got the storage classes and then we've got the performance options for our storage. Firstly, it's provision throughput. So you actually specify the amount of performance, the amount of throughput you wanna be able to drive to that file system regardless of how big the file system is the other one is bursting throughput. Now here the throughput will scale according to the amount of storage.

So the more storage you have, the more throughput you have and then it supports bursting to high levels as well.


### 53. Amazon Simple Storage Service (S3)

OK. So let's talk about the Amazon simple storage service. S3, this is a W S's object based storage system. So in an object based storage system like S3, we have a container and in the case of S3, they call it a bucket.

So the bucket is the container in which you store your objects. Now, objects are basically files that you put inside the bucket. It can be any type of file. So S3 does support any type of file, videos, PDF S MP fours, audio, whatever it might be.

And of course, we can create lots of objects in our bucket. In fact, the bucket can store millions of objects. It scales very, very easily. It's very cost effective as well.

So it's a cheap way to store large quantities of data in the cloud. Now, how do you access the objects in a bucket? Well, there's two different URL formats. So S3 is accessed over the web using a URL.

So the end point for S3 is an http S URL. Now the URL will be one of these two different formats and it includes the bucket name, the region and the key, the key is the name of the object or the file. OK. It's a key value store.

S3 is a key value store. The key is the object name, the file name, the value is the actual data itself. Now we're using HTTP here because it's a rest api So actually what's happening is the HTTP methods like get put post, delete, select and so on are being used to work with these objects in the bucket. So when you upload an object, it's gonna be a put or a post.

And when you download an object, it's going to be a get request. So we're utilizing the rest API over the internet makes it very easy to program with S3. If you're a developer, you can simply leverage one of the aws SDKS, the software development kits like bore for Python, and then you can write easy snippets of code in order to in integrate your application into S3 for storage S3 is accessed over the internet. So those http S URL S they are public facing URL.

S. Now remember that a bucket is a container for objects. So we can create many different buckets in our aws account. But the name of the bucket has to be unique across Aws.

So essentially because we're using a public URL on the internet, part of the that URL is the bucket name. So of course, our URL S all have to be unique. So we use one of these formats, then we have the object. So the object consists of the key, that's the name of the object.

So if you've got a PDF, for example, and it's called my document dot PDF. Then my document dot PDF is the key, that's the name of the object and in a key value store, that's one of the core components. We've got the key, we've got things like the version ID, then we've got the value itself, that's the actual data. Now we then have things like metadata, you can associate various metadata with your object.

We've got sub resources and access control information like AC LS, access control lists that we can define right down to the object level. Now, we have resources, of course running in VPC S and sometimes we wanna connect those resources to S3, S3 sits outside the VPC in the public space of AWS. So essentially we're accessing it via the internet. If you by default, wanna connect from an EC2 instance to Amazon S3, you're gonna hit the internet gateway and then you're going to be routed to Amazon S3 using a public endpoint.

Now, that's not very good for our private instances. Of course, we can use net gateways. But anyway, we might sometimes say that we don't want to have our information going out into that public space. So rather than using those public addresses, we can create something called an S3 gateway endpoint.

This is one type of VPC end point that we can utilize and it means that we're directly accessing S3 using private addresses. So now our instances in both public and private subnets can be routed o over those private IP address spaces rather than going out to the public internet. So a very useful feature there for security. I just wanna finish by comparing file storage and object storage, easy to get these two confused.

So I just wanna clarify the difference. Most people are more familiar with file storage than object. So with file storage, we are storing our data in directories and we can create hierarchies of directories. So we can put folders inside folders inside folders and organize our data in a way that makes logical sense to us.

File systems are mounted to an operating system. So for example, with windows, if you're mounting a file system over a network, it becomes a, a drive letter and is just like a local disk drive on your computer. So they function like local storage. Now the network connection is maintained.

So once you've mounted that file system, it's always there for you to use and save data. If you want to save a file, you don't have to mount the file system. Again, it's just already there as a drive letter on your computer. An example, of course, here is Amazon efs.

Now, on the other hand, with object stores, the data is stored in a bucket varies fairly similar in a way to a file share at this point, but there's a flat name space, there's actually no hierarchy. Now, we can mimic a hierarchy by changing the key. And that means we're using something called a prefix. A prefix appears in S3 itself as a folder.

You actually create a folder, but it actually just forms part of the key part of the file name. So we're kind of mimicking a hierarchy that makes more sense to us S3 doesn't really care. So the hierarchy can be mimicked with prefixes. Now, we're accessing object stores using a rest API.

So an application programming interface. So we're using a language that's very common on the internet. Http. And using the methods of HTTP, the gets the puts the posts in order to work with the API and manipulate objects.

So again, very good for programmatic access for applications. Now, the network connection is completed after each request, there is no maintenance, you cannot map an object store to your file system. If you find software out there on the internet, that does that all it is is an application that's making those calls for you. But you don't actually have a mount on your operating system for an object store.

That's just not the way it works. Every time you want to work with the object store, you have to initiate a an API request to do whatever it is that you wanna do. And then the connection is closed immediately afterwards. So those are the differences between file and object storage and of course, with an object store.

The core example here is Amazon S free.


### 54. [HOL] Working with S3 Buckets and Objects

Hey guys in this lesson, I'm gonna show you how to create S3 buckets and then work with objects using S3. I've navigated to the Amazon S3 service. And really all we need to do at the moment is create a bucket. You'll see on the left hand side here, there's a few items, but the first thing to do is simply to create a bucket.

Now, the bucket is simply the container in which we're going to store our objects and our objects are simply files, any type of file. The bucket name must be unique globally. Note that this is a global service. You cannot select a region.

However, we do need to select the region in which the bucket is stored. The data is then going to be within that region only, but the bucket name is part of a URL. So it has to be unique globally cos it is used on the internet. So I'm just gonna call this my buckets and then I'm gonna make it unique.

I just type a whole bunch of random characters. OK? So that should be a unique bucket name. We now have these two options, general purpose or directory.

So this is for extremely low latency and it uses the S3 express one zone storage class. Uh We don't wanna use that one. We wanna use general purpose. So leave it on general purpose AC LS access control list.

More of a legacy way of providing access. There's still some use cases for using AC LS, but typically we're just gonna leave them disabled block, public access for this bucket. That means that you can't enable public access for the objects in this bucket. With this setting enabled.

If you need to, then you'll need to remove block all public access. OK? I'll leave that on for now bucket versioning. This means that we can enable it and it will keep different versions of our objects so that we can always go back to older versions if we need to default encryption is enabled by default.

So we've got server side encryption with keys that are managed by aws and within the S3 service. Alternatively, you can choose K MS keys and you've got this option here for dual layer server side encryption. So you've got a few options for encryption. The default is perfectly good for what we want to do here under advanced settings.

We've got something called object lock. This creates a right once read many model so that you cannot override the data. We'll just leave the defaults there and create this bucket. So once we've created the bucket, we can start uploading some objects into our bucket.

I'm gonna click on my bucket and we'll see. We've got a few tabs here. We've got objects, that's where we land initially and we can upload our objects or drag them and they will be uploaded properties. There's quite a few options under here.

We're gonna come back to that permissions. We can add things like bucket policies defining who is allowed to access this bucket, who or what. So these are resource based policies in JSON. We've got some metrics around our bucket.

We've got some management features in here and we've got this thing called access points to simplify managing data access at scale. So what we wanna do is come back to objects. We're going to click on upload and then we're gonna add some files, you can use any files you want in the course. Download, there's a S3, Amazon S3 folder and within there, there's a little zip file with a few images of some fruit.

Very simple. Uh I'm just gonna choose a couple of these and we're gonna upload these files. So we'll see they're now being uploaded. Now.

There's a few options here. We can change permissions. If we've enabled that option at the moment, it's not enabled and under properties. This is where things get interesting.

We can choose which storage class we want for these objects. By default, they'll go into standard, OK? With milliseconds access, but you can then choose other things. Intelligent tiring means that aws is gonna work out which class is best.

So they're going to monitor utilization standard II A. If you don't access the data too often one zone A I A, if this is infrequently accessed data, and you don't mind it being in one availability zone. So you're gonna reduce the availability and you can see the availability here, whether it's how many availability zones it's stored in, that's gonna determine how often you can actually access this data. Because if one A Z fails, then obviously you've lost access.

So for high availability, you want it across more availability zones, then there's glacier. This is more for archival where you'll data for long periods of time. And of course, each of these classes comes with different prices. Standard is fine for this use case you can optionally change the encryption option on, on an object by object basis.

So now I'm just going to upload these two files. So that was very quick. If we come back to objects, we can now see that we have these two files, both JPEG images. If I click on one of them, it's going to take me to this page and we can see we don't have bucket versioning enabled.

It's giving me a warning there. They they like us to enable these features. It's given me some detail about things like the storage class. And then here we've got the object URL.

Also, very importantly, we can see the key. So the key, remember this is a key value store. The key is the name of the file. And then we've got the object URL which is the HTTP URL.

It's http SS it's secure URL for accessing this image. Now, if I click on that URL, copy it and try and go there, we're gonna get an access denied message that's not going to work. We'll come back and fix that in a moment before we do that. I wanna show you something else.

First, I want to show you another feature. We can create folders to mimic a hierarchy. Remember I told you that the object based storage systems do not have a hierarchy. So what if I create my documents as a folder and create that folder?

Now, I can go into my documents and I can upload some different files. Let's get the Raspberry file, click on upload and now it appears that I have some hierarchy. I've got Apple dot Jpeg, Papaya dot Jpeg. And then I've got my documents with Raspberry in it.

OK? However, if I click on Raspberry, look at the file name. The key is my document slash Raspberry dot JPEG. So actually the file name as far as S3 is concerned is that entire text string there.

It doesn't care about the slash, it's completely meaningless to S3 to us. It makes things appear a little bit easier to organize in the console, right? So what we wanna do. Next is I'm going to enable a bucket policy.

Now, here on the permissions of the object, we see the access control list. You can make objects available individually using the AC L. What we're gonna do instead is we're gonna come back up to the bucket level, go to permissions. Now, I'm not going to be able to add a bucket policy because that allows public access because block all public access is enabled.

So first I have to edit, remove that check box, save, confirm and that will enable me to now create a bucket policy. I'm gonna click on edit and then I'm gonna create it using the console here. I'm gonna add a new statement for principle. I'm just gonna get rid of those curly things and I'm gonna put a asterisk for action.

I'm going to type S3 colon, get object, then I'm gonna put resource colon and we're gonna specify the bucket a RN slash star. Now there's an error. I didn't put a comma before if I put that comma in there. Now, I'm saying that all principles are allowed the action.

We get objects on the resource and it's the bucket name, but it has to have the slash star. What we have with the bucket policies is if you remove that slash star, essentially what we're saying is that we are allowing the S3 get objects action on the bucket that doesn't work, it won't even allow us to do that. So it says here, action does not apply to any resources in the statement. So what we have to do is put slash star.

Now we're applying this statement. So we're allowing get objects on the objects themselves. So that should work. Now let's save the changes.

OK. Now that works and it's all objects. What we should be able to do is copy the object URL for one of these and let's paste it in and I get the image of the apple. OK?

So now I've enabled public access for my objects. So those are the basics of working with objects on Amazon S3.


### 55. [HOL] Create an Amazon S3 Static Website

Hey guys. In this lesson, we're going to use a feature of S3 which is to create an Amazon S3 static website. I'm on the S3 management console and what I need to do is create a new bucket. I'm gonna call this my website and then make it unique with some random characters.

It will be a general purpose type in us East one, I'll leave the AC LS disabled, but I do want to deselect this option to block all public access. Because for this website, I will need people publicly to be able to access the objects we need to acknowledge and then simply scroll down and create the bucket. So now I can go into my website. We're gonna go to the properties tab, we're gonna scroll to the bottom of this screen and then we've got static website hosting, simply click edit enable and it's gonna say hosting a static website, we're gonna leave that option.

It now wants these two documents. The error's optional. We don't need that one. We wanna specify index dot html as the name of the default document.

That's the object, that's the file that's gonna have the website on it and it's gonna load that file when people come to the website, endpoint, all we need to do then is save those changes. And if you come back down to the bottom, we now have a website endpoint, we need to now have a file whi which is our index dot html file. So in the course, download, you'll find the Amazon S3 directory and there's an index dot html open that in visual studio code. What you need to do is scroll down and you'll see that there's the file names here.

Ok. So what we have in that directory in the Amazon S3 directory of the course. Download, you'll find a little zip file with some images of fruit. You don't have to use those.

You can use whatever files you want. I'm using JPEG images. Uh I'm gonna go and upload a couple of those to my bucket. So let's come back to my buckets, go to objects, click on upload, add files and here's some of my images.

I'll choose three of these pineapple, papaya apple and add those in. And so what I'll need is I'll need these file names. So what I can do is just come back over here, I'll just use a copy and paste before I upload them to make my life a bit easier. I can give it a description as well.

Maybe without the dot JPEG on it for the alt text that is I'm gonna copy Papaya dot JPEG. Pop that in here, same again. And then we'll do the same for the third object, which is the apple dot Jpeg. Put that in between the inverted commas.

It's got the old description as well. Doesn't need Jpeg on there. And that's all I need to do for this particular file. I'm actually gonna save this one onto my desktop as index dot html and then we're gonna go back upload these objects and then we also need to upload that index dot html.

So I've got those free files which are referenced within the html code. Then I'm gonna upload this time. I need to pop down to my desktop. I've got the index dot html.

Upload that file. And now we have everything we need now that we have these four files. We've got all the objects we need, but we do need to enable permissions. So we head over to the permissions tab, click on edit for bucket policy.

I'm gonna add a statement. The principle needs to be a wildcard. The action needs to be S3 colon, get objects and then we need to add the comma, then I need to create a new line and resource colon. And then we're going to add in the bucket A RN between these inverted commas here.

Then of course, we need to add the slash star. OK? That's everything that we need for the bucket policy principle is anyone allow S3 get object capitalization very important here. All of this syntax is important.

Make sure yours is identical to mine comma here but not here and then save changes. Now we go to properties, scroll to the bottom, click on our website endpoint and we have our nice gallery of fruit for our static website. So there we go. We've now created a static website on AWS note that this is not secure.

So it says not secure. This is http only for these static websites. If we wanna secure experience, we have to use cloudfront in front of our bucket. So that's how you create a static website on Amazon S3.

S3 has a very generous free tier. So you don't have to worry too much about deleting everything immediately. But once you're ready to, you can just go in and delete your objects and then you can delete your bucket. You have to delete all objects before you can delete the bucket.


---

## Part 7: AWS Database Services


### 56. Introduction

Hey guys, welcome to the databases section in this section. I'm going to teach you about a couple of different database services on AWS. Now, there are a huge number of database services. These are two very important ones, the Amazon Relational database service and the Amazon Dynamo DB service.

Now, one of these is relational, the other is non relational. I'll teach you what that means in the very first lesson where I'm gonna help you to understand some concepts around the different types of databases we have and the different use cases that we can put them into, we then get into the database services themselves and I'll show you how to launch and create these databases in the cloud.


### 57. Database Types and Use Cases

Hey guys in this lesson, I'm gonna cover different types of database and the various use cases associated with them. So we're gonna start off with perhaps one of the most important distinctions and that is relational versus non relational databases. So what do we have? Let's have a look on the left hand side, we have relational databases.

Now in a relational database, the data is organized by tables, rows and columns and we have a rigid schema and it is this is in line with the structure query language SQL. Now by rigid, what we mean is that there's some very distinct rules that are enforced in the database. So we define the schema, what data is going to be included and where what types of data and once we set that schema it's kind of locked in. So it's not as flexible as with a non relational.

Now we typically scale vertically. There are a couple of options here. So for example, with relational databases to scale right traffic. So right to the database, typically we're scaling vertically, we're adding more power to the actual database server itself.

However, you can then fragment by assigning uh different parts of the database into different tables on different databases. So you're kind of scaling it horizontally and then joining them together starts becoming quite complex. Uh Examples of relational. We've got Amazon relational database service R DS, you've got oracle my SQL IBM DB two post grads on the non relational side, these storage models are a bit more varied and you have a flexible schema.

Sometimes they refer to it as no SQL to set it apart from SQL based databases. So data is stored in key value, pairs, columns, documents or graphs. There's few different types of non relational database. There aren't any rules strictly defined in the actual database itself.

So the rules are defined in the code if you need those types of rules. So outside the database, now a non relational database like Dynamo DB on AWS will scale horizontally. They are unstructured. They use a simple language that supports any type of schema.

So we've got Amazon Dynamo DB as an example, we've got Mongo DB, we've got Redis and the 04 J. So the key differences here are how is the data managed and how is the data stored? Let's have a look at a relational database here. So here's an example of relational database.

We've got those columns and rows. SQL is used for defining the structure of the database and its elements. And it provides the tools for inserting updating, deleting and querying the data within the database table. And here's an example of an SQL query where we're running a site, next statement for the first name from the employees database.

And then we're putting in the location equals Atlanta to narrow down our search a little bit. Let's move on to non relational databases here. We've got an example. Now, no SQL databases can be key value and document stores.

There's other ones as well which we'll look at in a moment. But Dynamo DB for example, it is a key value or a document store. So here is an example in this case of a key value store. Now there's no rigid schemer.

So the attributes can be missing or they can have different data types. And you can say, well, I'm gonna add an additional attribute, I'm gonna store something in the database that has an attribute that wasn't even defined before and that will just appear in the database for that particular row. Now, there's also graph databases. So Amazon Neptune here is one of the examples and they store manage and navigate relationships in data.

So imagine Facebook, there's all sorts of relationships. I know somebody, they know somebody and there's this interconnection. And of course, Facebook will keep a mapping of all of those different interconnections. So graph databases use nodes to represent entities, edges to represent relationships and properties to store information about the nodes and edges we then have operational versus analytical.

Now this is really about the use cases and how the database is optimized. So either relational or non database can then be operational or analytical. So on the left hand side, we've got operational also transactional. So these are online transaction processing databases, oltps.

For example, this might be a production database where in an ecommerce scenario, you're actually having some orders placed. OK. So the orders are getting logged into that database. It's good for short transactions and simple queries.

So examples here would be Amazon relational database service again, oracle IBM DB two and my SQL non relational examples of operational or transactional database types would be Mongo DB, Cassandra Neo four J and H base on the right hand side, we then have analytical so also known as online analytics processing or a databases. Often the source data will come from OLTPD BS. So here we have, for example, data warehouses where you are collecting information from your OLTP databases and running more complex queries and long transactions on them. For example, here we've got redshift, we've got Teradata HP Vertica.

And in the non relational world, we've got Amazon Elastic Mapreduce or mapreduce. So let's have a look at an example. Here we have Amazon R DS databases. These are the operational databases, the OLTP databases, they're receiving data from applications.

So these could be each associated with ecommerce stores where orders are being logged. Then we wanna take that data centralize it into a data warehouse and use it for analytics. So we can collate all that sales data into one place and then run some kind of complex queries. Maybe we're looking for trends in the data set.

So with Redshift, you're performing a copy into the database and then you can run your analytics. Let's finish this lesson. We're going through a few of the databases on AWS and their use cases. Now, first we've got database on EC2 that just means that you install it any database that you choose on an Amazon E two instance, whether that's on a windows or a Linux instance, you would do that if you want full control over the instance and the database.

So you wanna manage every level from the operating system, right, the way through to the database. You could also put third party databases like some kind of engine that's not supported through R DS on there. That might be a reason to use EC2 R DS here. It's where you need a relational database.

You've got a few options with the engines. You've got oracle post grays sequel, Maria DB my SQL, for example, Aurora as well, the data is well and structured. So a relational database, then you've got Dynamo DB. This is when you need a no SQL database provides in memory performance, high IO needs and dynamic scaling very good performance, very cost effective.

Then redshift is for data warehouse requirements. So where you want to take data from OLTP database is aggregate it together and then perform analytics. Lastly elastic cache, very useful service for speeding up access to data in a database. So it is in memory and it can cache information from the database.

It can be used on its own, but it's often used in front of other databases like R DS. For example.


### 59. [HOL] Create an Amazon RDS Database

Hey guys in this lesson, I'm going to show you how to create an Amazon relational database service and R DS database using the console. So let's head over to relational database service. We can just search for R DS. And here we go, the managed relational database service.

Of course, this is a managed database. So they do a lot of the work for us. What we can do here is we can on the left hand side, just head over to databases and of course, we don't have any databases yet. So what I wanna do is create a new database, so I'm gonna click on create database.

There's a couple of different options here, I'll leave it on the standard, create. And the first thing we need to do is to choose which type of database do we wanna deploy? So which engine do we wanna use? The default is the Aurora my SQL compatible.

That's what aws would like you to use. There's also Aurora post grades and then there's course these other different engines that are supported on R DS as well. We're gonna choose my SQL if I now scroll down a little bit we can see we've got a few options here for engine versions. I don't wanna change any of those settings.

We can choose production dev test or free tier. And that's essentially a template that defines certain settings for us. For example, if I wanna make sure that I keep this within the free tier, I can select free tier here. Now, that's gonna gray out some of these deployment options.

For example, if I want to have a multi A Z database cluster for redundancy where we have a primary and this is two readable stand by DB instances in that case. Well, I definitely want to use production maybe DEV test. Let's see. Yeah, DEV test does support it as well.

So it changes the instance types and some of the other configuration parameters and some of the configuration uh s uh configurations are not going to be compatible with these various deployment options. So when we go to free tier, then it's basically just gonna be a single DB instance. OK? That's fine.

I don't mind that that's good DB incidence identifier just identifies the instance. So let's just call this my R DS DB. Now we've got the user name. I'm just gonna leave it on admin.

We could use secrets manager for our credentials, so we can store the credentials including things like the connection parameters, like the host endpoint address and the port number and the user name and password. All that information can be stored in secrets manager. And then within our code for our application, we can reference the secret that way if something happens. For example, we're failing over from our primary database to a replica in a disaster scenario, we can always change the end points in there.

And our application automatically picks up the new database. In this case, what I wanna do is just come down and set a password. So I've got my password set. We can see that we have ad BT free micro instance here.

So this is one of the DB instance classes that's going to be compatible with the free tier. Otherwise you could go through and choose something else. But we can see a lot of them are grayed out because I chose that free tier template next up. We've got storage, it's allocated a 20 gig storage.

That's fine. It's a GP two SSD. There's other options here as well. So you could use GP three if you need more performance.

Then of course, there's the IO one as well. So we're just gonna leave that as the default. There's storage, auto scaling. I'm just gonna leave the default there.

We're not gonna scale, we're not gonna add any data to this database. You can choose to connect to an EC2 instance. If you have an EC2 instance to connect the database to, you can choose your VPC or just leave it on the default. We've got the Subnet group which defines various things including the Subnet and IP ranges.

The DB instance can use, we'll just leave the default there. There's only one subnet group in my account. Next, we need to choose whether we want public access or not. Usually I'm not going to have public access because I want instances that are within my VPC which are my application servers to actually access the database.

So in that case, we can leave it on no, for security group, I can choose a security group here. And let's just say I wanna choose one of these. I need to make sure that the relevant rule is available. So I've got security group one here.

I'll have to go and check that the my SQL port is open. Next, we can choose the availability zone if we wish to or we can just leave it on no preference. We can create an R DS proxy if we want to. So if you want to have very high scale for R DB connections and make sure that they are served very quickly.

For example, maybe our application layer is a very fast scaling lambda function, then you might want to use an R DS proxy. I'm just gonna scroll down. We'll leave password authentication on rather than move to curb Ross or I am and I will leave enhanced monitoring off. I don't need that at this point and it's showing me the total monthly cost.

Ok. So we're not gonna be running this for very long. Let's just go ahead and create the database. So that's created now, R DS is not particularly fast.

So it's gonna take a few minutes to create AWS are now asking whether we wanna set up a proxy using R DS proxy for connections or maybe you wanna set up a caching layer in front using elastic cache. I'm OK for that. I'm just gonna close this down and we're gonna leave it a few minutes. It can take several minutes for your database to become ready.

So it's been a few minutes. My instance is in the status backing up. So it's almost ready. If I click on the DB identifier, we can now see some information very importantly including the endpoint and the port number.

So if you were to be connecting an application to this, you wanna make sure that your security group has port 3306, the my SQL port open, we can see the availability zone VPC, the subnets that are available in the subnet group and so on. And then there's of course some monitoring information. You can enable enhanced monitoring as well to get more information. But here we've got some information about the DB instance.

So once the DB instance is up and running, we can connect our application using the endpoint address, we can use the actions menu to take several different types of action. We can view the configuration here. So we can see the DB instance ID, the engine version, the instance class and so on, on the actions menu, we can take a backup so we can take a snapshot. That's a point in time backup.

Essentially, this is a manual backup. Whenever we wanna take one also under maintenance and backups, we can see here, we have the automatic backups enabled and it's keeping one day's worth of backup. If you have any additional snapshots, there's one that's been taken here as part of the creation process. You can see those snapshots at the bottom and we can see that the maintenance is automatically enabled.

This is part of the management that AWS provide. So we have the auto minor version upgrade. Now, I might want to do something else. Maybe I want to create a read replica.

For example, we can do that here. So let's do that. Let's click on create read replica. And I'm gonna call this, it's gonna have a separate DB instance identifier.

So I'll simply call it my replica. And we can see the replica source is automatically set to our database. We could now change the instance configuration for this replica. You could also change the region.

So you could have a cross-region read replica and the storage configuration. And so on, this doesn't really apply, but it kind of seems to have it all set up for you as if you're creating a multi A Z. But we're actually creating a replica here, just within the same region, you could change the security groups. I'm gonna leave that as default.

In fact, everything here is going to be a default. I'm just gonna create the re replica, read replicas will take a little bit of time to create. So if we come back to our databases up here, just give this whole page a refresh and we can see both databases. So now you can see that we have the main database which is being modified because we're creating a replica from it.

And then you've got the replica and it's showing that it's connected. So now any data in the database is gonna be replicated to the replica. And we're gonna have that ongoing asynchronous replication. When the replica has completed, we'll also have an endpoint and a port.

So that takes a couple of minutes just like the main database. Once it's ready, we'll have an endpoint and that endpoint can be used for read operations only after a few minutes. My replica now has an endpoint and a port number. Of course, the port number is the same.

It's still my SQL but we can see that the endpoint is different to the end point for the main database. So now we have two different end points, one that we can direct read and write traffic to and the other, the replica where we can only send read traffic to so that it the databases are deployed. This is almost finished. It does take quite a few minutes.

But what I'm gonna do is I've finished with this lab for now. So I'm gonna go ahead and delete my database. So let's put delete me in here just to confirm, that's gonna start deleting the replica and then we can delete the main database as well. I don't need a final snapshot.

I also don't need to retain backups. So I'm just gonna acknowledge that all the data is going to be deleted and that should clean everything up for me.


### 60. Amazon DynamoDB

In this lesson, I'll cover Amazon, Dynamo, DB A W S's non relational database service. So Dynamo DB is a fully managed no SQL database service. It's also a fully server service. So you don't have any instances to worry about.

It's a key value store and a document store. So the data types you store can be chosen from one of these two options. It provides low latency access to data in the region of milliseconds and push button scaling with no downtime. That means you can adjust the performance characteristics of Dynamo DB without there being any downtime to your database at all.

Now, the way that AWS stores data is in partitions which are replicated across multiple A Zs in a region. And when you adjust the performance characteristics of your database, they adjust the way that the data is stored to provide those types of read and write performance. At the same time as your database grows as well, it gets stored across more partitions. So it provides lots of durability.

You've got that red, see in there and you've got great performance. Now there's a few features. So firstly, it's serverless. As I mentioned, fully managed and fault tolerant.

It's highly available with four nines availability SL A and five nines. If you use global tables which replicates your data across regions, it is a no SQL database. So it has a flexible schema. It scales horizontally with that push button scaling no downtime whatsoever.

There's a feature called Dynamo DB streams. Very useful feature. It captures a time ordered sequence of modifications to the items in the database. Now, an item in Dynamo DB speak is essentially like a row in a relational database.

So whenever you modify the database, it's going to actually record what was changed, what was added deleted, modified, that information can then be utilized by other services. So you can have services like lambda read from the stream and then process that information in some way for transaction options. You've got strongly consistent or eventually consistent reads and support for acid transactions as well. In terms of backup, you've got point in time recovery down to the last second within the last 35 days and on demand backup and restore.

So that's when you're doing it manually. Global tables is a fully managed multi region, multi master solution. So that's when you have your table across two regions, you can see the same data in both sides, you can read and write to both regions and the data is gonna be replicated in both directions. Let's have a look at the core components of dynamo DB.

Firstly, we've got tables. Essentially, you're creating a table within an existing database, that's what's happening and you get to manage at the table level. So everything you see there is within a table, then we have items, items are essentially rows in the database. We then have attributes.

So each of the items in the database has one or more attributes we can see here, there's a few different attributes associated with each item in this particular table. In terms of dynamo DB pricing, primarily it's based on provision throughput or on demand capacity with provision throughput. This is where you understand the characteristics of your application, you understand the database performance requirements and you specify what those are going to be. And then you're paying for the certain amount of reads and rights per second.

So if your database is fairly consistently using a certain amount of reads and rights makes a lot of sense on demand is where you're paying for what you use. And so it's gonna scale more with your database. So if you're not sure of how much reads and rights your database requires or your application, database requirements are going to vary quite a bit, then on demand can make a lot of sense. And then we've got storage costs as well.

So you're paying for the data storage that your tables actually consume. You also pay for some additional features like global tabless and Dynamo DB streams, backup and restore as well as data transfer as well.


### 61. [HOL] Create an Amazon DynamoDB Table

In this lesson, I'll show you how to create an Amazon Dynamo DB table and we're gonna load some data into it using the command line interface. And then we're going to practice with the query and scan API s using the CLI and I'll show you around the console as well. So let's head over to Dynamo DB. Just search for Dynamo DB.

Here it is a managed no SQL database. And what we're gonna do is we're going to create our first table. So the database actually exists with Dynamo DB. What we're doing is creating tables within it.

So all we need to do here is click on create table in the course. Download you'll find the Amazon Dynamo DB directory and within that the create table, add data markdown file. So here it tells us what we need to put into the settings for our table. Firstly, we need to set the table name to my orders and it is important that you follow these instructions.

So I'm gonna paste the table name in my orders, then we're going to specify the partition key and the sort key. So this is part of the primary key the partition key is a unique value has to be unique for every item in the table and it can be used for retrieving our items. We'll see how to use it later on when we search for our data and then we have the optional sort key as well. So let's come back and find the primary key which is going to be client ID.

We'll put that in and then the last one is the sort key which is created. Now, those are the only settings that I need to specify. I could change some of the other settings like I can specify the table class that I want to use. For example, infrequently accessed or standard, you can choose the capacity mode.

So how do you want to uh essentially set the amount of throughput that you require the amount of operations that you can perform against your table? And there's even a capacity calculator here to help you to understand the impact of the settings that you apply. Now, I'm just gonna leave it on the default settings and then scroll down and create my table. These tables are really fast, not like R DS where you're waiting for 10 minutes.

This should be ready in literally a few seconds. So now I have my table ready in the same folder in the course. Download, you'll find this batch dash, right dot Json. What you'll find in here is we have a series of individual items that are going to be added to our table.

So we have the my orders table specified and then we can see we have a put request and an item. So there's 20 different items in this document. Each one has the client ID as an email address. And that's a unique value associated with each of the customers.

Then the created is used as well. That's the created. So it's basically a time stamp and we have the SKU we have the ele the category. So electronics for this one and so on, and you can see that they're either string values or number values.

In this case, this file needs to be uploaded to aws cloudshell. So I'm gonna come back and just open up cloudshell and in cloudshell, once this is ready, I'm going to o upload my document so that we can run a CLI command to actually load all of the information into our table. So let's click on actions, upload file and I'm gonna select my batch right dot JSON. And now the files uploaded.

Let's just check, it's there. I've got my file ready for the command back in the create table. Add data document here, it tells us to upload the file. We've just done that and then we can use this CLI command.

So we're gonna use the batch right item. It means that one operation is going to actually write all 20 of these items to our table. So I can come back, put in the command press enter and it should come back with unprocessed items and there's no response in there. So that's good.

It means everything was processed back in the Dynamo DB console. What we want to do is click on explore items, select my orders and now we can see that we have 20 items returned. So we've got all of these different items in our table. Now, by the way, I mentioned before that the client id, which was the primary key needs to be unique.

Well, of course, people might place multiple orders when you have client id and a sort key created. It's actually the combination of these two together that need to be unique in the table. So in this case, for example, client four could purchase multiple items because the date stamp and the time stamp is likely to be different. Therefore, it constitutes a unique value in the table.

So here we can now see that we have all of these different items in our table. Now, you can see that it says here the reid capacity units consumed were 0.5. So we have reid capacity units and right capacity units. That's how we allocate the amount of performance on our table and how many operations we can perform.

And it's how we're actually charged. So here we've got scan and query. What just happened was a scan. You can also filter by things like specific attributes So you can then filter down by the attributes that you're interested in.

And then there's also the query API as well. The query API queries the whole table and then we can filter the results. What we're gonna do is see how we can actually scan and query from the cli. So back in the document here, we're going to go down to section three or number item three, you scan API S defined data.

So this first example is gonna demonstrate how to scan the my orders table for items in a specific category in this case, electronics. And of course, you could change that to one of the other categories as well. So I'm just gonna copy this command, which is this line here from 25 to 28. Let's go back to cloudshell, confirm that I want to paste this in and that's a single command.

Let's run that command and then we get some responses. And if I press the space bar, I can just filter through those responses and then queue to exit. So that's a scan. Next, this example shows you how to scan the table for items where the quantity is greater than two.

So let's see how many of those we have. I'll come back, I'll clear my screen so you can see better. Let's paste this in and press enter. OK?

So now I've got one item there, a couple of items and we can see finally we get a count and it says free. So it's scan 20 items and three of them fit my search criteria. Next up, we have the query API S so we can see this one here is looking for orders made by a specific client identified by the client ID. So I can copy these lines here.

We're running query now, whereas before we were running scan again, we're specifying the table name. We've got a condition expression which is client id equals client id. And then under here, we've specified the specific client id. So let's clear my screen again, paste this in press enter and we can see that we get some responses back in this case, just one.

We can also see it only scanned one item because of the filter that we had in place. So let's quit out of there and then come down to the final one. This one is looking for orders from a specific client within a certain date range using the sort key along with the partition key. So here we've got some time stamps.

So we're actually searching for orders made in a specific time period. So let's paste that one in press enter and we get some results again, count one scan, count one. So only one order actually matched that criteria. So that's a little bit about dynamo DB.

If we come back into the main console here, there's quite a few other items that I can show you. So let's go across to indexes. These are ways that you can perform queries on attributes that are not part of the primary key of the main table. So we can create these things called global secondary indexes.

We've got some monitoring here. We've got global tables which is the multi region, multi master table where we can actually have multiple copies of the same table in different regions and we can read and write in those different regions. We can set up backups here point in time recovery, which is off at this point in time, we can always change that. We can also take manual backups when we need to, we can set up streams here.

You can create a Dynamo DB stream so that every item level change that's made in your table can be recorded and placed into the stream for processing, for example, by a Lambda function, you can export S3. You can also place information into dynamo into kinesis instead of dynamo DB as well. And then finally, there's a few more settings here in terms of adjusting stuff like your table capacity if you need to scale your dynamo DB performance. So that's everything I'm gonna show in this particular lesson.

Let's come back up and I've finished with this table. So I'm just gonna go ahead and delete it and I don't want to create a on demand backup. So I'm simply going to confirm and that will delete my table


---

## Part 8: Automation and DevOps on AWS


### 62. Introduction

We're getting into some really exciting stuff now on AWS automation and devops. So we're gonna start off this section learning about cloud formation. Cloud formation is infrastructure as code. If you've heard of Terraform from Hashicorp, that's a very similar thing.

Cloud formation is specifically for AWS. It means that we can deploy our infrastructure, all of those different things we've deployed so far in the course, all of those can be deployed through cloud formation by supplying a template, which is basically some code written in J JSON or YAML cloud formation, makes it really easy to repeatedly deploy our infrastructure on AWS securely and without error. Then you're gonna learn about Amazon Elastic Beanstalk. Elastic Beanstalk is a implementation of what we would call a platform as a service solution.

So I'll teach you all about what that means as well. So Beanstalk means that we can simply upload code to AWS and it's gonna run on EC2 instances in the cloud and be managed by AWS for us. So it's a simplified way of deploying code with a managed service that takes care of a lot of the hard work for us. Then we get into the continuous integration and continuous delivery tools from AWS, the developer tools, they're known as we have tools like codecommit, codedeploy and code pipeline.

This is where we can start automating the deployment of code, committing our code to repositories, building it and then deploying it right through to the AWS services that are gonna run our code. And I'm gonna show you how to do all of this in hands on lessons. So lots of fun tools to play with in this section. I'll see you in the next lesson.


### 63. Infrastructure as Code with AWS CloudFormation

Hey guys, welcome to this lesson in this lesson. We're gonna be covering infrastructure as code I AC and I'm covering the tool from AWS themselves called AWS cloud formation. So with cloud formation, we can deploy infrastructure using code defined in a template file. If you're used to hash a core terraform, then basically this is a very similar product, but it's specifically an AWS product only for use within AWS.

So cloud formation is where we can define our infrastructure patterns in what we call a template file using code. And that code can be formatted in either JSON or YAML formats. We then supply that file to cloud formation and cloud formation will go and build the infrastructure on AWS according to the definitions in our template file. For example, building out a VPC, launching an Autocad group with instances in it and attaching an elastic load balancer.

So all of this can be performed using cloud formation. In fact, you can deploy pretty much everything in Aws using AWS cloud formation. Cloud formation really helps as well with reusability and consistency. So once we've built out our templates, we can reuse them again and again.

And it provides that consistency, less chance of human error. So the core components of cloud formation, firstly, we have those template files, as I mentioned, these are written in either json javascript object notation or YAML. So these are text files which contain the instructions for building out the AWS environment. Using those template files, we then create a stack within cloud formation.

So the stack is the actual entire environment as described by the template. So we launch a stack, it's gonna create our infrastructure, it's gonna go and deploy that auto group that VPC, whatever it is that we've defined. And those will exist for as long as the stack exists. If we delete the stack, aws cloud formation is actually going to by default, terminate or delete all of those resources for us.

So it actually rolls everything back. So essentially we're creating using a stack and then we can actually update the stack as well and perform updates or even delete that stack just as a single operation and remove all that infrastructure. Now, a stack set is essentially a stack except that it extends the functionality such that you can now create update and delete stacks across multiple accounts and multiple regions with just a single operation change. Sets are a really useful feature of cloud formation here.

What we can do is we, if we wanna update our cloud formation stack, we wanna implement some changes to the deployed infrastructure. We can document those as an update in our template file, we supply the template file and we ask cloud formation to produce a change set. And what it's gonna do is it's gonna provide a summary of what's going to be changed. It's gonna point out the differences between the deployed infrastructure and the new template file that we're supplying, that gives us a chance to review and say, yep, that is what I intended to do in that case.

Great. I'm gonna release it into production and it's at that point in time only is cloud formation gonna go and actually make the changes. Alternatively, you might see that it's not exactly what you intended. So now you haven't deployed any mistakes into your environment and you can cancel the change set and then go back and rework your template.

So that's it for a basic summary of cloud formation. This really is a service where we need to go and get our hands dirty. Do a hands on lesson, actually see cloud formation in action to really learn how it works.


### 64. [HOL] Creating and Updating Stacks

Hey guys, welcome back in this lesson. We're going to use Aws cloud formation to create and then update some Aws cloud formation stacks. So let's head over to Aws cloud formation in the Aws console and here very simple page. It just asks us to create a stack.

OK. We can see on the left hand side, we've got stacks stack sets and exports. And if you land on the main page, then again, it's just create stack. That's the main call to action here.

So what we need to do when we create a stack is firstly choose whether we have a template that's ready, we can use a sample template or we can even create one in the visual designer. So the visual designer gives us a visual interface obviously for creating our cloud formation templates. I don't know how many people really use this. You can sort of drag and drop items on here.

Um But it's a bit of a cumbersome way of doing things. I think most people don't use this, they, they just, you know, create their own templates um or use existing templates and modify them. That's basically the way that I work. If I need to do something in cloud formation, I try and find the closest template I can and then I will modify it to my needs.

So in this case, we wanna upload a template file in the course, download, you're going to find a cloud formation directory. And in there there's these free files, 1 EC2 template, 2 EC2 template and free EC2 template. So these are YAML formatted template files. YAML is a bit easier to read with cloud formation templates and don't worry about the date here.

That isn't incorrect. That is a value format for the uh the template version. What this one is going to do is just a quick description here. It's gonna create an EC2 instance with a security group for SSH access.

So the first element here is resources we can see we've got the instance security group. So we want to create the security group first so that we can then attach it to the instance. We have the type which is AWS EC2 security group and it has a description. So here's the properties.

Importantly, of course, we need to specify an ingress rule because we wanna allow SSH access. That's port 22 you do from and two, that's the way it's specified. And then the Cider block, which is all zeros, which means any source address. Once we've got that, we then are able to create the instance.

So this has a different type aws EC2 instance, we've got the properties. Very importantly, we've got the image ID. You'll wanna make sure that this is a current ami. So let's go back and to the console and I'm gonna head over to EC2 and I'm just gonna click on launch instance and we're gonna use the Linux 2023 AMI.

So I can just select the AMI ID here, copy that and that's the latest Ami now I've already updated mine. So it looks like mine is correct. Let's just check. Yep, that's the correct one.

You'll want to do the same in the other templates as well. Now that you've got it on your clipboard, you can see that there's three places where you need to paste that Ami ID. So we've got the image ID, the instance type is T two micro and then here we're using this reference intrinsic function which looks up the instant security group. So it's going to attach that security group to the instance.

All right, that's how that works. Let's come back to cloud formation and I'm going to select my template file. Choose the first one. Click on next.

Now we're going to provide a stack name, E two instance lab and then click on next. We don't need to specify any specific permissions. In this case, it's gonna take the permissions associated with our user account. The default behavior is if there are any issues in the creation process, it's gonna roll back and delete and terminate all resources so I can just leave the default.

So there's a few advanced options as well, but I'm just happy to move on, click on next, scroll down and then finally submit. Now we can watch what's happening. So we have the events here and if we click on refresh, we're gonna watch everything that's happening. We can see it's creating the incident security group that it is now complete, then it's going to start launching the instance.

So if we come back to EC2, now we can see we have a pending instance. If we click on the instance here, let's head over to security. We can see that it's using a security group and that is the security group that was created within cloud formation. If we come back up, we can actually see the resources that are being created here.

And if we click on this link, it will take us out to the instance. That's what the physical ID is. By the way, a logical ID is the reference to an item within the template. The physical ID actually links you to the resource outside of cloud formation.

So I've come back to events. So let's just refresh again, create complete. So it didn't take long. We now have a running EC2 instance.

Now we have another template here. The second one, this is going to attach an EBS volume, retaining the original resources. So note that this is has some additional elements but it has all the original elements. So this is a full template which has all of the original elements from the first template, but it also has the additional volume configuration as well.

So we're gonna attach a volume to the instance. We can see that the size here is going to be 10. And it's making sure that the availability zone is the same A Z as the EC2 instance because otherwise we won't be able to attach it. We can see we're using reference intrinsic functions again to select the instance on which to mount the EBS volume.

Now I'm going to submit this as what's called a change set. So in the actions menu, I'm gonna create a change set for the current stack. If I click on replace current template, upload, choose file, select the second file and then click on upload just close that error. I don't know what that was but everything's working.

So now we're gonna click on next. It's giving the change to a name. I'm happy with the name, click on next again, next again and finally submit what we can see now is it's actually letting us know what the changes will be. There's no crate that's happened.

The updates have not been deployed to production at this point in time. It's just showing us the difference between the templates and it's telling us that what's gonna happen is a volume is going to be created and then attached to our EC2 instance. If we're happy with that, we can then go ahead and execute the change set and then click on, execute again. And now we have an update in progress and we can see what's happening.

Let's head over to EC2 and I'm gonna go to storage here. We can see it only has one storage volume, but let's refresh here. And now we can see there's a second storage volume with 10 gigabytes of volume size. So that's our second update.

If we come back and refresh again, let's just check. Yeah, it's complete. So we've got an update, complete status message. Now finally let's go over to our third template.

This one is gonna add an Amazon S3 bucket. So maybe our instance needs to log to an S3 bucket. Again, it's going to retain the original resources and it's going to add this one here. This is a very simple.

It's literally just a few lines of code here. The type is S3 bucket, the bucket name of course needs to be unique. So you wanna make sure that you make this unique. I just add a bunch of random characters in there and then save my template file.

So let's come back in and again, we're gonna use a change set, replace current template, upload, choose a file, choose the third file, click on next and then again, it's the next, next and submit. And now we can look again to see what those differences are, you can refresh on the right hand side and we can see it's gonna add an Amazon S3 bucket. Well, I'm happy with that change. So I'm gonna go ahead and execute my change set.

So now if I head over to Amazon S3 shouldn't take long for me to find my S3 bucket and there we go, that's the new bucket that's just been created and there that didn't take long, the update is now complete. So that's how we can use cloud formation to deploy resources and make changes to deployed stacks. Once I finish with a stack which I have for this exercise, I can click on delete and it's gonna warn me that deleting a stack will delete all stack resources, resources will be deleted according to their deletion policy. So you can set deletion policies within your templates to define, for example, that you might want to not have certain resources deleted.

So I'm gonna click on delete and what we'll see now is a delete in progress. And if we watch the events, we can see things happening, the bucket is gone already. If we come back over and refresh that bucket is gone and we're gonna see these remaining resources being deleted. Now, there's often an order, for example, here, it's gonna need to delete the volume attached to the instance ahead of the actual instance.

So we'll probably see the storage layer being removed. There we go, the volume is gone and now the instance is gonna be shut down. It's always worth just watching and making sure that everything does get deleted correctly because there can be instances where things hang for some particular reason. And if so there's usually a status reason to let you know what's going on and then may maybe you have to go back in and actually terminate some resources yourself.


### 65. [HOL] Deploy a VPC Using CloudFormation

Welcome to another hands on lesson in this lesson. I'm going to deploy a VPC using AWS cloud formation. The template used in this lesson is a little bit more complicated. This one is gonna deploy a VPC with a pair of public and private subnets across two different availability zones and an internet gateway and the route for the internet gateway so that we have public subnets with full internet connectivity.

Now you can see there's a little bit more to this template. Firstly, we have parameters, these allow you to define settings that you can then see in the console and even modify or in some cases you can use a drop down list to select from some certain options. In this case, we get to specify the environment name and that's gonna be prefixed to all the resource names. So it helps us with identification in the console for VPC Cider.

There's a default setting but we can override it in the console, same with the Subnet Cider blocks as well. Then we can see the resources the VPC gets created referencing the VPC Cider block. Then there's an internet gateway type AWS EC2 internet gateway. We have the internet gateway attachment.

And then we have the different P subnets, the public subnets and the private subnets. We've got the public route table here again, that has to reference the VPC and you can see the tags that are always being added on. That's the environment name. So that's adding that string.

So it helps us with recognition in the console. And then we've got the route table associations. We've got the route table here for the private subnets, the route table associations for those private subnets as well. We have a security group and then we have some outputs.

We'll have a look in the console to see the outputs. This means that the information will be output into the cloud formation console to let us know what's being created. So let's head over to cloud formation and use this template. I mean cloud formation.

I'm gonna create a stack, choose upload a template file, choose file and choose the VPC with cloud formation dot yaml. Then click on next. Now we have these parameters exposed to us. We always need to provide a stack name.

I'm gonna call mine CF dash VPC and then for environment name, I'm gonna choose the same CF dash VPC and that will be prefixed on all of the resource names. Then we have the parameters for the VPC Cider and the different Cider blocks for the individual subnets. I'm happy with leaving these defaults, but I could easily override them if I wanted to. Let's click on next.

We don't need to change anything here. Click on next again, scroll down and then click on submit. As always, we'll have the events here. So we'll be able to see the events as they're happening.

This will take several minutes. There's a few elements of this configuration which have to be to be deployed in certain orders. And so it does take a few minutes to actually complete. So you can keep, keep refreshing to see what's actually being created.

You can also come over to resources as the resources are being created. We'll see the various logical and physical I DS here. And once they've been created, we'll have outputs as well. So we'll come back to that shortly.

Let's just give it a minute to complete. Oh In fact, it was very fast this time and it's actually already complete. So if we refresh on the outputs page here, we can now see some information about what resources were created as well as looking here where we have the actual physical I DS as well. So for example, I can click on this item at the very bottom of the page here.

That's gonna take me over to the VPC in the VPC management console and we can see it has this prefix, has this name. Now, if we come down to subnets again, we can see here if I just order them, these are the subnets with the environment name prefixed into the name of the subnet. So we know what is what same for route tables. We've got the route tables here, internet gateway, we have the internet gateway.

And of course, if we go into the route table for the public subnet, there should also be a route to our internet gateway. So very simple. That's all I wanted to show you for this lesson. Very straightforward way of setting up a VPC.

Of course, we can define all of the settings and security optimizations we want for our B PC in the template file and then we can deploy it over and over again. And we have the choice then to define the different Cider blocks as we deploy it. So very useful way of creating BP CS. Let's come back.

I've finished with my VPC. So I'm just gonna go ahead and delete it.


### 66. Platform as a Service with AWS Elastic Beanstalk

Welcome back in this lesson. I'm gonna cover platform as a service with Elastic Beanstalk. So you remember this from earlier on? So we have infrastructure as a service and platform as a service.

I just quickly want to compare the differences with infrastructure as a service. And of course an example here would be Amazon EC2. We have essentially a virtual machine, a virtual server or instance depending on what terminology you wanna use with a virtual machine, you have to manage from the operating system upwards. So Aws is taking care of the hardware layer underneath.

They're taking care of the hypervisor and the various software for service catalogs and delivery, but you still manage the operating system. So you've got to install those patches, harden the operating system, all those types of things and then at run time. So if you're running a a that runs on a programming framework like java runtime, you've got to install that and you've got to update it and manage it. In the case of platform as a service, you simply upload your code and your data.

So for a developer, this is much better because they don't necessarily want to manage the operating system or the run time, they wanna concentrate on writing code and then just uploading it and having all that other stuff taken care of for them. So that is what elastic Beanstalk is going to do. Now, the good thing is with elastic Beanstalk, you do however have access to the operating system. So though a lot of it is managed for you, you do still have access.

So if you do need that access for some reason for operational or management reasons, then that is still a possibility. Let's have a look at Beanstalk in action. So here we have a developer, the developer is gonna upload source code in the form of a zip file. So the source code gets uploaded to Beanstalk.

All the developer cares about is writing their code, packaging it up into the zip file and then they upload it to Beanstalk. Beanstalk is then gonna create the Elastic Beanstalk environment. The environment can include an auto scanning group with instances inside and a load balancer which is gonna distribute incoming connections. Now everything within the environment is launched and managed by elastic Beanstalk.

The developer simply created the environment and defined which VPC which subnets and availability zones. Beanstalk is taking care of the rest for the developer. So very simple to deploy your code and have it running on Aws beanstalk supports many application platforms. You've got java.net, no JSPHP, Ruby Python go and Docker for example.

And it uses core aws services including Amazon EC2. Amazon elastic container service, auto scaling and elastic load balancing. Beanstalk also provides A U I to monitor and manage the health of your applications and it provides managed platform updates to deploy the latest versions of software and patches. So let's have a look at how it's actually made up.

So the components of Beanstalk start with something called an application. So there are several different layers. Let's understand these, we've got applications first, these contain the environments, the environment configurations and the application versions, you can have multiple application versions held within an application. So we start off by creating an application in BEANSTALK, we can then have our application versions.

These are references to a section of deployable codes, so we can upload different versions of our code and that code is going to be available. So each version of the code is still going to be available. If for example, we want to roll back the application version will actually point to an estuary bucket, which is where the code is actually contained. So you'll notice that when you upload the code to your application, you will then find an estuary bucket gets through and the different versions are going to be stored and maintained in there versions can then be applied to any environment.

So here we have development and production environments and we can apply the different versions of our code to those different environments. And apply those settings independently of each other. So what is an environment? An environment is an application version that's been deployed to AWS resources.

The resources are configured and provisioned by Elastic Beanstalk. And the environment is comprised of all the resources created by elastic Beanstalk and not just an EC2 instance with your uploaded code. So for example, if we're deploying an auto scaling group for high availability of our application and a low balancer, all of that is going to be deployed and managed by elastic beanstalk within that environment. And we can choose which version of our application code we want to apply to that specific environment and roll back or change or upgrade whenever we need to.

Now, another concept we need to understand is the difference between web service and workers. Web servers are standard applications within bean stalk that lessen for and then process http requests typically over port 80 or of course port 443 for the secure port. Workers are specialized applications that have background processing tasks that listen for messages on an SQSQ and workers should be used for long running tasks. So we've got the web servers.

These are the ones that are published towards the internet or behind a load balancer and they're receiving the incoming connections from the internet. Perhaps people are submitting some kind of order. For example, if it's some kind of e-commerce application, then the workers might take some information that's been placed into a queue by the web server and perform some kind of processing on that information. And so when we have long running tasks, things that are gonna take time, we wanna offload that from the web servers and that's where the workers come in.

So let's have a look at how this works here. We've got a worker environment and a web server environment user hits the web servers places some kind of order, for example, and then information about that in that order or that request is put into an SQSQ by the web server. So the web servers placed a message in the queue. The worker is polling the queue and it finds the message and then processes that message.

So that's the difference between web servers and workers. And you get to choose which one you wanna deploy when you create your environment.


### 67. [HOL] Create an Elastic Beanstalk Application

Hey guys, in this lesson we're going to create an Elastic Beanstalk application. I'm logged into AWS and I have navigated across to the Amazon Elastic Beanstalk console. We're gonna deploy an application on Elastic Beanstalk, and to do that, what we need to do is click on create application first. Now here we have two options.

We can either create a web server environment or a worker environment. So a web server environment is when we're actually gonna be running a website, for example. So this. Is the web front end.

If, for example, our application then needed to perform some processing of data that was submitted by our customers, for that we would need a worker environment. So within the application, we can create web server environments and worker environments. Now in this case, we're just gonna create a web server environment. Now a couple of things you will need for this is, one, you do need to have a key pair.

So in EC2, make sure you've got a key pair. Secondly, you will need to have an instance profile. Now we've already created those in the training courses, so it actually doesn't matter which one you use, if you have an instance profile that you can attach to your EC2 instance, that's fine. But those are actually requirements for the setup, even though we don't necessarily need them.

So I'm gonna give this an application name. I'm gonna call this web app one. Scroll down and it's gonna create an environment so we have. Application within the application we have the environment, and this is the web server environment within Web App one.

It gives a name, I'm happy with that. Now we could set up our own domain name if we want to. So I could call this something like digital cloud app. Check the availability, it's available.

All right, let's go ahead and use that as a custom name. Now I can choose the managed platform. So remember, this is a platform as a service solution. And AWS provides a variety of different application frameworks for us.

I'll select no JS. Now what it's gonna do is it's going to default to using a sample application. That's fine, it's just gonna be a very simple website. We just want to.

See this running, so I'll leave that as the default. We've now got these various different presets because we could be deploying a single web server or a highly available web server. We can use different types of pricing model like spot as well, or we can customize. Now I'm just gonna leave single instance, and it is free tier eligible.

Click on next. Now in the old days, when they, before they actually refreshed the whole console to what it is today, that was about it. You could literally just click a button and it's gonna create the environment for you. But now it actually requires that we do a few things.

Now, one is that we need to select a service role. If you have used elastic. Stork before, then you can use an existing service role and you'll see this name. If you have not used it before in this account, and no one else has in this account, then you can create a new service role by just selecting this option, and you can leave the name exactly as it is.

Now I have run and as Beanstalk applications before, so I'm gonna use an existing service role. Now, even though I don't necessarily want a key pair, I do have to select one. And even though I actually don't want an instance profile, I have to select one. So I'll select the S3 read only which I created earlier on.

So remember the instance profile is just a way of assigning permissions to your instance. So if I wanted to provide access to S3, then I would attach an instance profile. In this case, I actually don't want one, however, it does error if I don't select one. Same with the key pair.

Now let's click on next. A few more screens we need to go through. We can launch in our custom VPCs if we wish to. I'm, I've only got a default VPC at the moment in this particular account, so I've selected that one.

I can now choose whether I want a public IP. Yes, I do want a public IP and I can select one or more subnets. So one is fine in this case because it's just an individual instance. If I was to do a highly available one, then.

Might want to do 1 A 1 B. I'll just select 2 anyway, and we'll see where it goes. We're not using a database. You can actually deploy a database as well, so we're not doing that at this stage.

So we'll just scroll straight past all of those settings there, click on next. I'll leave the defaults here for storage. Cloud watch monitoring. Yep, that's fine.

I don't need to change anything there. I'm going to select a security group that I have. You'll need to make sure. 480 is open in the security group you select and make sure the security group is in the relevant VPC as well if you have multiple VPCs.

For capacity, it's gonna create an auto scanning group with just one instance because we're not using a load balance deployment. So I'll just leave that as it is. Scroll down. Now you can select different instance types here.

So for example, I could choose T2 micro. To make sure that I get a free tier instance for this application. I'll leave the AMI as it is, click on next. For monitoring, I'm gonna leave it on basic, scroll down and I'm gonna deselect the managed updates.

So Beanstalk will apply updates automatically. It actually does require that you have the enhanced health reporting on. I'm gonna switch, so I'm gonna switch these two off just to simplify things here. I don't need email notifications.

I'm not worried about deploying updates at this point. So I'm just gonna scroll all the way down, click on next, and we're just in the review now so we can scroll down, make sure that we're happy with all the settings. I am, so I'm gonna click on submit. So now it's gonna launch the environment for us and that will just take a few minutes.

Once the environment is configured and deployed, then we should be able to navigate across to the domain name here, and we should see a splash screen for No JS website. While this is happening, you can actually scroll down a little way. Under events, you can see some of what is actually happening. In EC2 we can see that we have a running instance and that instance is going to run our website.

So we can now see that it's actually in our account so we can actually access this instance ourselves. If I scroll down and go to auto scanning groups, we can see we have an auto scanning group, so even though we only deployed one instance, it does create an auto scanning group. And the good thing about that is it's going to ensure that there's always one instance running. So if that instance failed for some reason, then it's gonna launch a replacement instance, so we know that's gonna happen for us by virtue of the ASG.

Coming back, I'm just gonna leave this for a moment and wait until it's ready, and as I say that, there we go, it is actually ready. So I'm gonna click on the domain URL here, and that takes me across to the splash screen for the. OJS application. So very simple exercise, but now we've got our application running.

Now just to help you navigate this console in the middle here, we have the events. We've then got health. We switched off some of the settings here, as you can see, it does say enhanced health is disabled. We've got some logs, so you can actually request the log files for the instance and it's going to display them here, for example.

For the last 100 lines. We've got monitoring, again, there's different levels of monitoring, we can have basic or we could have the advanced monitoring. We've got alarms here that we can set if we wish to. Managed updates, which we turned off, but otherwise, AWS would actually manage the instance by innate by deploying updates to the platform.

Now on the left hand side, first we've got configuration. So if you did need to make some changes to the configuration that you deployed, this is where you do it. You can see the various different options. We've got the service access, we've got the networking and database instance traffic and scaling if you wish to switch to having multiple instances.

And updates and monitoring, so if we change our minds and we want to enable that, then this would be the place to do it. On the left you can also click on events, that takes you to basically just that screen there, health logs monitoring, we already looked at those. So that is a web application deployed using Beanstalk. Now up here you can see we've got application versions.

This is where if you deploy updates. To your application, you'll see the numbered versions in here and you can then actually sort of separately manage these and deploy them to your environments or even roll back to previous versions of your application. At the very top here on the left, you've got applications, of course, we created an application. Remember, the application is essentially the container into which we then deployed our environments.

And at the moment we just have One environment. Now, in this case, I have finished with this environment, so what I can do is come in here and terminate the environment, copy the name from the top here, paste that in and then terminate. After the environment has been terminated, you can go and delete your application. It's not gonna cost you anything, the actual application, but you do have to wait until the environment is deleted before you're able to do that.


### 68. Continuous Integration and Continuous Delivery (CI⧸CD)

Hey guys, if you've been exposed to DEV ops, then you've probably heard of continuous integration and continuous delivery or C I CD. And if you haven't heard of it before, no problem, that's what we're gonna cover. Now, we often see some kind of graphic like I show on the screen here which starts with planning, then coding, then building our code, then testing our code, then releasing our code, then deploying it, operate and monitoring, finding out what is wrong with it and then going back into that planning phase coding, building testing releasing. So it's a cycle that just keeps on going.

So the C I CD tools that we're gonna focus on for this particular course are the AWS developer tools. Of course, there's lots of third party tools out there. You've got your Jenkins and Answerable and git and github and all those different types of tools. Now, in this course, we're gonna concentrate on the Aws developer tools.

Of course, there's lots of third party tools out there as well. You've probably heard of Jenkins and Answerable and github and so on. But in this course, we're gonna focus on Aws. So we're gonna be looking at the code tools.

So they all start with code, we've got code commit, we've got code build, we've got code, pipeline, code deploy and there's a few more as well. So let's have a look at what these different services will actually do for us. So here we have a developer. The developer is of course writing code, that's what developers do.

And the developer wants to push their code up to a repository. Now, of course, in the real world, you might often use GIT instead of co commit or that's what you might be used to if you're already a developer. So GIT is very similar. So where we have git and github, you're actually using the GIT client in this case to create a reposit Tory in code commit and then push the code into that repository.

So co commit is very similar to github. So the developer has pushed the code into codecommit, codecommit is integrated into codebuild here. So it's gonna push the changes that have been made to the code in the repository through to codebuild. Codebuild is a build server.

So it's gonna build and test that code check if there's anything wrong with it. And if so report back to the developer. So we get results that come back to the developer, the developer can then utilize those to either push some changes back up to code commit and go through that cycle again. Or in a case where the code is ready to be deployed, it can then be deployed.

Now, what we often do is build something called a pipeline and there's a service called AWS code pipeline that helps us to do that. So starting that process again, the developer is pushing code to code commit. That's the repository code commit through the pipeline is then going to automatically notify code build, the build server is then gonna build and test the code results can go back to the developer but also the code, if it's ready can be pushed through to codedeploy and Codedeploy is going to then release that code and deploy it through to the end application. And there's integration from Codedeploy into various different services from third party ones to lots of aws services like EC2, LAMBDA and ECs for as well as cloud formation as well.

So the code's been pushed out to the application now. So all of that has been automated through the pipeline. In fact, the developer here has simply committed some changes to the code and that code has gone all the way through to the application and it's gone through this process. So it's had some build and some tests performed on it.

And if it's passed those tests only then has it been deployed out to the application? So that's C I CD with AWS developer tools in the AWS code pipeline. When we get into the console, you'll see there's several other services as well within the developer tools framework. So there's quite a lot of scope for developers to work with native aws tools, building C I CD pipelines.


### 69. [HOL] AWS CodePipeline with AWS Elastic Beanstalk

Hey guys. In this lesson, we're going to deploy some updates to our Elastic Beanstalk environment using a code pipeline. So we're gonna create a code pipeline. We're going to use Aws code commit and then we're gonna deploy through to Aws Elastic Beanstalk.

So what's gonna happen is we have our developer here who is going to push code updates to AWS code commit. The pipeline will notice those changes, the updates to the code and then push that code through to elastic Beanstalk deployment, pushing it right through to our environment and updating our environment with the updates to the code. So now our developer can always make changes using the code base in git push and commit those changes up to code commit. And the deployment goes right through to the application back in the Aws management console.

I have my Elastic Beanstalk application running and if I click on the domain name, it just takes me over to this page which is green on the left, then kind of dark on the right hand side. Now we're gonna make some changes through code updates and co commit. First thing to do is head over to Google and we're going to find some code from AWS. So search for elastic Beanstalk sample node Js code and that should take you to this page tutorials and samples.

I'll add it to the lesson as well. So you can download from there. And what we want to do is come down here to where we find node Js dot zip and simply download that code. So we're gonna make updates to that code in a moment.

What we want to do next is I'm just gonna quote. In fact, I'll leave that open so we can refresh it. And then we're gonna come back and we're going to open Aws cloudshell and we're gonna use cloudshell for the rest of this exercise. So we're gonna have cloudshell.

That's gonna be where we're going to uh commit our changes to our git repository. But firstly, we need to set up that repository and our git repository is gonna use code commit. So code commit is a W S's get compatible code repository service in code commit and note that we are now in with all the developer tools. I've opened codecommit, but you can see the code build service, code, deploy code pipeline, they're all related.

So what we need to do is create a repository. Let's just call this my node app and I'm gonna create, that's really all we need to do to create the repository. We can then use the clone UL and we're gonna clone using HTTP S and that's how we're gonna clone it down to cloudshell. Cloudshell will have the GIT client installed by default.

Now, if you choose to do this on your own computer and you've installed the GIT client, you will also need credentials. So you'll have to go to your user account. And what you wanna do is go to secu security credentials here. Scroll down to where it says HTTP S get credentials for co commit and generate some credentials.

And then when you try to clone your repository, it's gonna ask you for that information. Ok? I don't need that because I'm going to use cloudshell. So I've cloned or I've copied my clone URL to my clipboard.

Let's go to cloudshell and hopefully this is nice and clean. Ok? I can get rid of that file just to clean things up. And then what I'm gonna do is run GIT clone and put in the URL.

OK? So it's cloning that into a local folder. And in fact, this has asked me for a user name. It didn't do that before.

So let's go back to I am. And what I'm gonna do is I'm gonna create some new credentials for myself so you can see this in action. So we go to security credentials. Http S GIT credentials.

I'm gonna take the user name here. Come in, pop that in and then it's gonna have a password for me as well. So let's copy that password. Come back to cloudshell and then paste that in.

OK? And it says you appear to have cloned an empty repository. That's not really an error. It's just factually correct.

So let's change to the directory. And of course, there's nothing in here. But now this is a G directory. So we can see if we run, get status.

There's no commits on branch master. What I need to do now is upload from the actions menu. I'm gonna upload a file and I'm going to go to my downloads and there, I've got this node Js dot Zip. That's the one we just downloaded before.

So let's upload that one and that's uploaded straight to the home folder. So if I change back up again, we should now see the node Js dot Zip. So what I'm gonna do is run Unzip, no Js dot zip dash D and then the application directory. And now if I change into that directory, let me just clear the screen.

So you can see more easily and run Ls. We've now got these files and if we run git status, it's gonna tell us that these are untracked files. So what we can do is we're gonna make an edit first and then we're going to add and commit these files and then push them up to the repository. So, what I'm gonna do is I'm gonna use the nano tool to edit the index dot html and I'm gonna come down a little way.

So I'm gonna scroll past that first reference to color, which we can see here to the next one, which is the background color here. And we're gonna change basically the background color. And what we're going to enter is double zero, double four, double F. And then I'm going to control X type Y to save and that's save my file.

So I've changed the background color in the index dot html file. Now let's add run gad dot uh with a dot To add all the files and then we're going to run GIT commit, dash M and put in a message initial commit. And then we're gonna run GIT push. Now you might get an entry like this.

It's saying that the author identity is unknown. Please tell me who you are and it's saying that you should run this and you can supply your email address if you wish to or you can literally just add this in as it is. I'm just gonna run those two commands to just tell it a certain name. And if you, what's happened here is we need to come back to the commit because the git commit command actually failed before the gpus and then we'll run Gpus, ok?

Now it's asking for those details again. So you wanna make sure you keep a note of these, I've got them up here. So I'm gonna add in my user name, add in my password. And now it's gonna push up the data to our repository.

So if we come back to the repository here, let's just select our repository. We can now see that we have a series of files. OK? So we've pushed that code up to our repository.

Now, of course, it has not gone out to our application yet because we haven't created a pipeline to push those changes through to the elastic beanstalk environment. So on the left hand side, we're gonna select code pipeline. Click on pipeline, we're going to create a new pipeline and I call this my node app, leave the defaults for V two and superseded execution mo uh execution mode. And then we're gonna allow it to create a new service role for us.

Scroll down, click on next. Now we need to choose our source provider. Of course, that's gonna be code commit. So choose code commit, select your repository and then select the master branch.

Click on next. This is where you could use code build to build and s and check your artifacts, perhaps build the deployment files or check the code. In this case, we can skip the build stage. Click on skip again for deployment provider.

This is where you could use something like codedeploy or cloud formation, but there's a direct integration with elastic beanstalk. So we're gonna choose that option, select our application and select our environment and then click on next. And that's all we need to do is scroll down and create the pipeline. OK?

So this has dumped us on this page here where we can see that it's already identified some changes in code commit. So that's in progress and it's gonna push those changes through to elastic Beanstalk that's now succeeded. So now it's moved from the source stage to the deployment stage and that's going through to elastic beanstalk. If we come back to beanstalk, click on events, we can now see that we have an updated event.

This is actually happening right at this point in time. So it's deploying the updates. Um And if I click on the link now it's blue. OK?

It used to be green. So now we can see that we've made a change to our code and it's pushed that code through to production. Let's go back to Cloudshell and we're gonna, I'm gonna clear screen again. Let's nano the index file.

Now let's just change something else and then push this through. So we can see now it happening in real time straight after I've made the update. So perhaps rather than congratulations, I'm gonna change this message to hello Neil. And again, I need to run through a few commands here.

So we're going to run the GIT A, we're going to add the GIT commit dash M and then I'll write a message, edited index and then git push. And of course, it's gonna ask us for the user name, password each time. So I'll add this in, add the password and push that through. So now if we come back to our pipeline, we should see this update very quickly.

So just keep an eye on and you should s see this change any second now. And in fact, we can see it already happened before I even came back to the page because the message here edited index is the latest message. So that's going straight out to the Elastic Beanstalk deployment. We come back to elastic Beanstalk and refresh.

There we go. It's updated very, very quickly. So that's it. Now we can push updates through code commit using the GIT clients and that's gonna push the changes all the way through to our application via the code pipeline.

OK? So I have finished with this particular lab. So what I'm gonna do is just close out of, we'll come back to our pipeline, we can delete things in here. It's not gonna cost you anything when it's not actually running but feel free to go back, delete your repository and your code pipeline.

The way it works in Beanstalk is we need to come in and terminate the environment. So remember we have applications and within the application, we have environments. So within each application, we can have multiple environments. So when you come in and terminate an environment, it's not actually going to delete the application, you need to come and do that separately.

So we'll come back to the environment here, I'm going to terminate the environment and once that's terminated, if I wish to, I can then deploy uh delete the application as well as the environment.


---

## Part 9: DNS, Caching, and Performance Optimization


### 70. Introduction

Hello and welcome to this section in this section. I'm gonna cover a few different services which cover the areas of DNS, the domain name system, caching our content for content delivery around the world and then performance optimization as well. So you're gonna learn about route 53 which is a DNS service, but it's not just a traditional DNS service. As many of us are familiar with, it has some advanced intelligence as well in how it can direct responses.

So think of it as an intelligent DNS service has a few other capabilities as well like registering domains. So you'll learn about route 53 and how we can use it for various use cases. And you'll have the opportunity to register your own domain which you can use in this course and others as well. When you're practicing with a W SS, we'll then look at the content delivery network service.

Amazon cloud front cloudfront helps us get content around the world closer to the end users who are consuming it so that we get better performance, for example, videos, images and so on. And then we'll look at global accelerator which actually utilizes the cloud front network to accelerate access to our applications that are deployed behind, for example, load balancers in different regions. So lots to get on with. I'll see you in the next lesson.


### 71. Bandwidth and Latency

In this lesson, I'm gonna cover a couple of very important networking concepts, bandwidth and latency. So these are a couple of ways that we can measure the performance of networks here, we have two different computers and they're connected with some kind of networking connection. Now, the bandwidth is the rate of data transfer for a fixed period of time in gigabits per second. You can think of it almost like the width of the communication band.

How much data can you get down the wire? Next, we have latency and one of the main factors in latency is distance because this is the delay, the amount of time it takes to send the communication from one side to the other. And it's typically measured in milliseconds and microseconds. So one of the most important things here is distance.

If we have two computers that are separated across the world, what one is in the US and one is all the way over in Australia, then the distance, the length of that connection is going to cause the biggest delay, there are other factors as well. And we're going to cover those shortly. But latency is essentially how long does it take to send the information from one side to the other? And the bandwidth is the amount of data that you can actually send down the wire.

So here we have a example where we have two computers within a data center, this might be measured in microseconds because the latency here is going to be very low because they're so close together just a few meters apart. On the other hand, if we're communicating across data centers, now it could be in the milliseconds could be a few milliseconds could be tens, could be hundreds, even depending on the distance between these two locations here, it could be miles and kilometers or even hundreds or thousands of kilometers. So if we look on a global perspective, of course, if we have two computers, which are opposite sides of the world like here, then there's gonna be a great amount of distance between them. This could result in tens to hundreds of milliseconds of latency.

Now, as I mentioned, distance is usually considered to be the most important factor, but it's not the only one, there are other factors as well. So greater distance does equal higher latency, that's a given without a shadow of a doubt. However, some of the other factors that may contribute to network latency include the propagation delay. This is the time it takes for the signal to travel from source to destination.

OK. So that is what we were talking about before that's the distance principally. But then there's the transmission delay, the time required to push all the packets and bits into the wire. And this depends on the packet size, the data rate of the link, the bandwidth and the type of medium that we're using as well.

Queuing delay is the time a packet spends waiting in a queue until it can be processed or transmitted. And we have the processing delay, the time routers or switches take to process the packet. So if you think about that long connection between the US and Australia, there's no one wire that connects those computers, there's gonna be lots of different wires. And between those, there's gonna be lots of different devices like routers and switches.

Each one of those needs to process the packet and forward it to the next part of the hop towards the destination. So the greater the distance also more likely the larger number of devices that are gonna be in the pathway that also adds to the delay. So those are the core differences between bandwidth and latency. Normally, we just think about latency as how far apart things are.

And then we're talking about microseconds or milliseconds. And depending on the application, some applications are much more sensitive to that latency than others. It doesn't really matter with an email whether you have high latency with a voice call, for example, over the internet latency really matters. And then bandwidth is, is more about how much data can you get down the wire?

So the speed of your download, for example, if you're downloading a big video file is going to be principally dictated by the bandwidth that your particular network connection has.


### 72. DNS and Amazon Route 53

In this lesson, I'm gonna cover the domain name system, DNS and Amazon route 53 which is a service on AWS, which provides DNS functionality as well as some other features as well. So DNS is a really important system. We use it every single day, even if you don't know it. When you're trying to connect to a computer over the internet, the computer is actually using IP addresses for communication.

Computers don't use domain names like amazon.com. However IP addresses are difficult for us to remember. So instead we utilize a system where we can actually use words so we can type in amazon.com into our web browser. The computer needs to then find out what is the IP address for that web server.

So here we got a connection happening from a client on the left hand side and the client is trying to connect to a web server which is on DC T labs.com. So the user puts in DC T labs.com into their web browser and their computer now needs to find out what is the IP address for the web server for DC T labs.com. So it connects to a DNS server and just simply asks the question. It's a DNS query, what is the IP address for DC T labs.com?

Now, the DNS server has something called a DNS zone file and that zone file contains IP addresses of web servers. If the DNS server does not have an answer for the question, what it does is it recursively forwards to other DNS servers. So in this case, it does actually have the answer. So it provides the response back to the client and the client can then connect to the web server.

So it used the IP address to communicate with the web server. That's the way computers actually communicate. When we're using DNS, we're using something called a fully qualified domain name. So here we got www.example.com.

That is an FQDN. Now at the end there, there's a dot which might look a bit strange to you, but actually there is strictly speaking a dot at the root of the DNS hierarchy, but we just don't use it. We don't put in amazon.com dot We just put in amazon.com and our browser understands that. But strictly speaking, there is a dot at the top of the DNS hierarchy, then we have com That's an example of a top level domain under that we have a subdomain, which is an example in this case.

And then we have, in this case, it's called a host name. So the host name, www is similar to a subdomain, but we're gonna see there is a difference in a moment. So www is the host name and that's gonna have a corresponding record in the example.com DNS zone. So let's have a look at subdomains here.

We've got a couple of examples, support.amazon.com and mail.google.com. So support and mail in this case are both subdomains of the domain above them. Now, the subdomain is a subdivision of the domain name where you can organize a set of related records. So in this case, support and mail might have a separate set of DNS records to Amazon and Google.

So that's why we have a subdomain. So within a DNS zone, we have records and let's have a look at some of the most common record types in DNS. Firstly, we've got the A record, this is the most common one used. So an A record maps a domain name to an IP address.

So you've got DC Labs two and then there's an IP, amazon.com two and then there's gonna be an IP for the web servers at amazon.com. You've then got ac name. A cname is a canonical name and it maps one domain name to another domain name. So here we have an example, mail dot DT labs.com to mail server one.net.

We then have MX records. These are mail exchanger records. We're turning the mail servers for a domain name. We got TXT.

These are text files often used for verification and authorization purposes. SRV, these are server locator records for specific types of server like Kross for authentication. NS is the name server records. These are the authoritative DNS servers for a particular domain.

That means they're the ones that have the answers for that particular domain name. And then we have the start of authority that simply stores some information about the domain. So it's the beginning of that particular zone file. So we have Amazon Route 53 and route 53 is a DNS service, but it has quite a few different features.

Firstly, we got domain registration. So that is that you can register your own public domain name using Amazon route 53. When you do so, it will create a hosted zone. Now, if you register a public domain name, it's gonna create a public hosted zone.

That is one which is accessible on the internet, which means that users on the internet will be able to connect to your website by looking up the IP address of the website on your public zone file. You can also create private zone files which get associated to a VPC. So you can maintain DNS records for internal servers. Route 53 also performs health checks.

That means it can check your instances or your load balances, for example, to check that they're active. So for example, we might have a deployment across two different regions with load balances. Route 53 also performs health checks so it can perform health checks against your EC2 resources your load balancers and other IP N points. So for example, you might have a deployment across multiple regions with load balances.

And what route 53 will do is it will check the health of the active region. And if there's a problem there, if it's not returning a correct health check a healthy return response, then it will actually start sending people to the other region. So in other words, the response to queries are gonna start pointing people to the second region. So that would be an active, passive fail over.

And there's a variety of different options that we can choose through routing policies on route 53. Lastly, here we have traffic flow which gives you a bit more logic in terms of how you direct traffic to different services like micro services, for example. So let's look at DNS resolution with route 53. So we're going to register a domain name in this case, a public domain name.

And here we have example.com, that's the hosted zone and that represents the set of records belonging to this particular domain. So now when a user on the internet queries for the IP address of example.com, the address is gonna be returned and the user can then connect to the web server I mentioned before that route 53 has different routing policies. So it's not just a simple DNS service, you can actually apply logic in how Aws responds to queries. So these are the different routing policies that are available.

Simple is very simple. It just provides a DNS response with the IP address associated with a name. Then we've got fail over. This is what I referred to before where we can utilize health checks and we can have a primary and a secondary destination.

So we might have low balances in two different regions. The primary is all traffic is gonna be sent there in the DNS responses as long as the health checks are returning healthy. And if they're not, then route 53 will stop responding with the addresses of the primary region. And it will start directing clients to the secondary region.

Geolocation uses the geographic location of the client to determine which region to send them to. So now you can have deployments around the world and send people to the most, the closest geographic region to them geo proximity routes to the closest region within a geographic area and then latency is all about latency. So what is the delay? What is the network performance?

Let's make sure that that users get sent to the better performing site, the the region that's closest to where they are usually. And then we have multi value answer that returns several IP addresses kind of like a basic low balance function weighted uses relative weight. So for example, we can configure the weighted routing policy to send around 80% of our traffic to one end point and 20% to another good when we're releasing updates. And lastly IP based is routing based on the originating IP address of the traffic.

So lots of functionality there to get quite clever in how route 53 responds to queries.


### 73. [HOL] Register a Domain Using Route 53 (optional)

Hey guys in this lesson, I'm going to show you how to use the Amazon route 53 service to register a domain name. It's not always mandatory that you do this. However, if you want to follow along with some aspects of some lessons in the course, it's gonna be very useful. Indeed, if you do multiple of our courses, I highly recommend that you do register a domain with route 53.

So back in the console here, we're just going to search for route 53. And we're gonna choose this first option here, scalable DNS and domain name registration. So within route 53 it does several things. It's got DNS management, traffic management, availability monitoring, health checks, for example, and domain registration.

So we wanna choose domain registration. You can also find that on the left hand side down under domains, you click on registered domains and here it will show you any domains that you've already registered. Now, what I want to do is register a new domain. So I'm gonna click on register domains and now you can select the domain name you want.

For example, maybe I will choose DC T lab training.com and it's gonna check if that's available. This one costs $13 a year. If I change it to dot Link, five bucks a year. So much cheaper, I think dot Link is probably one of the cheapest available options.

Now, it doesn't really matter too much what you choose, but I like the dot coms. So I'm just gonna go ahead and choose the DC T lab training.com and click on select and then proceed to check out. So now it's just a case of going through this process. Now, when you create a domain, you pay a one off price for a year and you can see auto renew is on, you might want to turn it off just in case you don't need it.

They will send you an email reminder and you can switch it back on again if you do need to continue using it for an extra year. The other thing is is there is a hosted zone created and there's a very small charge on that per month. I think it's uh 60 or 70 cents, but you can check the documentation for the latest price because they do change from time to time. So I'm going to deselect auto renew.

Click on next. Now, what you need to do is essentially just go through and fill out your information and AWS are then going to attempt to register the domain for you using the contact information that you supply here and the credit card that you have on your Aws account. Once you've finished filling out the form, you'll end up on a page like this one where you can see in the blue banner at the top of my screen. It's telling me that the request to register the do the domain is in progress and you'll receive a registration status email once that's complete.

Now, just a word of warning, sometimes I've seen that for new accounts, especially for people with a credit card that Aws has not seen before, it doesn't happen automatically and you actually have to go and check with Aws support. There's not a defined process for this. It's not publicly documented, but I know lots of students have had to do that. I've had to do it myself in a few cases as well.

So it may be the case that if it fails to register, you need to make a support case with Aws and then they will actually help you to get the domain registered. And I've just refreshed my screen and guess what? That's exactly what's happened. So this is not a new thing at all.

And luckily they do give us a bit of information here about how to follow up. So I'm just gonna go ahead and follow this link and then I'm going to s submit a support case. This may or may not happen to you. I can't guarantee anything because this is not a documented process.

And it just seems to be something that's been happening for several months now. So hopefully when you go through that process, they will authorize the domain registration and then you'll have a completed domain registration. And at that point in time, you'll be able to come up to hosted zones and you will find a hosted zone is being created automatically for you.


### 74. Amazon CloudFront

In this video, I'm gonna cover Amazon cloudfront. So cloudfront is a content delivery network that helps improve the performance of content that we want en end users to be able to consume from around the world. So let's first start off with what is a CD N. So a content delivery network is much like what we have with some of the popular services you'll be aware of like youtube.

So youtube, Vimeo, those sorts of platforms, they all have their own content delivery network. And what that means is that when you upload a video to youtube, that video is not just going to lo be located in a single physical location in the world. So here, for example, we can see it's in the east coast of the US. That's where the user was when they uploaded this video.

However, the consumers of the video could be watching it from all around the world. So what youtube are going to do is they're going to replicate the file to all of these different locations and there'll be many more than I'm showing here. This is just an an example. So we can see now that the same file has been replicated to several different geographies around the world.

That means that when users want to consume it, they're going to be directed to the closest and what we call in cloud front terms edge location. So an edge location is where the content has been distributed to and cached. So now users in these various different geographies are going to be directed to the closest video to them and that's going to improve performance in Amazon cloud front, we call these edge locations and there's hundreds of them around the world. So C DNS improve performance by caching content closer to the end users who are consuming that content.

So let's look at Amazon cloudfront with cloudfront, we create something called a distribution and inside the distribution, we have the origin, the origin is where the actual content comes from. So for example, here we have an Amazon S3 bucket and we've uploaded some various different types of files, html JPEG PDF. These have all been uploaded to this S3 bucket. We can also have other types of origin.

For example, here we have an EC2 instance that's running a website and delivering an HTML page and it's behind an application load balancer. So then we have the various locations around the world where this content is going to be distributed to and cached. So we have something called a regional edge cache and an edge location. There are fewer regional edge caches.

They have a larger bandwidth in terms of caching content. And then there's lots of edge locations, there's hundreds of these around the world, the exact number changes all the time because AWS are constantly expanding. So the content from the origins gets cached around the world and you actually have control over which geographies your content goes to. Then end users in the various locations around the world are gonna be directed to the closest edge location.

Now the edge locations, the regional edge caches and the origins are all connected via the Aws global network. So the only path that's on the internet is from the end user through to the edge location. What we see in green here, everything else is on the AWS global network, which of course is a network that's managed by AWS and therefore has good latency and good bandwidth. So our end users have a better experience here because they're being directed to the cache, copy of the content wherever they are in the world cloudfront, therefore reduces latency and improves performance.

Those are the key benefits of using cloudfront cloudfront utilizes the AWS global network for low latency and high performance connectivity. It delivers both static and dynamic content and optimizes delivery based on the content type. It also supports what's called live streaming and video on demand. VOD.

Then we have LAMBDA at edge, this enables processing data with LAMBDA functions closer to the users see what that looks like. So here we have the cloudfront cache, we have the S3 origin and we have the user who's actually consuming the data from the S3 origin via the cache. So what happens is the user connects, that's the viewer request. We can run a LAMBDA function here.

We can do things like transform that incoming request, we can inspect it, we can do whatever we wanna do through that LAMBDA function based on the code that we write. Then there's an origin request. If the content's not cached at the cloud front location, then an origin request means that the request gets forwarded through to the origin. So that that content can be downloaded from the origin and then put into the cache.

Again, we run a LAMBDA function there, then there's an origin response. Again, we can run a Lambda function and then a viewer response. So those are the four different locations where you can then run a Lambda function and just run some code and do whatever it is you wanna do to transform or inspect the information that's being passed to the origin or back from the origin to the viewer cloudfront uses http S for secure connectivity and it integrates with AWS certificate manager for managing the SSL TLS certificates. It also integrates with Aws shield and Aws web application firewall for additional security protection.

So there you have distributed denial of service protection with Aws Shield and the web application firewall means that you can create rules for protecting against malicious web traffic content can also be protected with features such as signed cookies, signed URL S and origin access identities and origin access control. Here we have a custom origin and cloud front. Let's have a look at the various different levels of security that we can apply. So here from the internet, a connections coming through the cloud front and then it gets passed through to the load balancer and on to the actual origin.

Now, by the way, here, we're showing an example where the request is going all the way through to the origin. There's two reasons why that might happen. One is that the content is not cached at one of the edge locations. The second one is that we've turned off caching.

So we might want to leverage some of the features of cloud front but still pass all requests through to the origin. That means that we still leverage the AWS global network users still get directed into the global network from the lo closest edge location to wherever they are. And then we can layer on these various different security features and controls that cloudfront supports. So here our request goes through to the application load balancer.

Now, SSL encryption can be applied all the way and that can come from AWS certificate manager. That's where we're managing those SSL TLS certificates, WF and shield can be added. So we've got web AC LS for AWS web application firewall and then that distributed denial of service protection with AWS shield and those controls there are applied at the cloud front distribution level. So we've got various layers of security.


### 75. [HOL] Create a Secure CloudFront Distribution

Hey guys, welcome to this lesson in this lesson. We're gonna create a secure Amazon cloud front distribution that's gonna serve a static website that's hosted on Amazon S3. So what we're going to create in this lesson is an Amazon S3 bucket, a certificate manager, SSL TLS certificate and an Amazon cloudfront distribution and then a route 53 alias record pointing to the distribution. So we'll have the bucket, we'll have the distribution.

Route 53 is gonna provide the domain services. So the DNS record and when a client then connects, they're going to get resolution via route 53 for the domain and then they're gonna connect to the cloud front distribution. The cloud front distribution will connect to the S3 bucket to pull the assets from the static website. And of course, that's encrypted using SSL TLS certificate manager is the service that we can use for that SSL TLS certificate.

So that's what we're gonna build out. Let's go and get on with it. I'm in the console and I'm gonna go ahead to Amazon S3. Now, I've cleared out some of my buckets.

So I need to create a new website bucket. What we have in the course download is the Amazon S3 files which you will find in the Amazon S3 folder. Within the course. Download in there, you'll find the index dot html file.

The index dot html file does need to be modified in the same folder in the Amazon S free directory of the course. Download. You'll find a fruits, a fruit images dot zip file. And within there, there's a few images you can use your own images, whatever you want.

But I've just supplied some for you. What you need to do is choose three of those images to present as part of the static website and just pop the name of the image in here. You can also add the image description if you want, but it doesn't matter. So I've just added the name of the image.

OK? That corresponds to the file name of that particular JPEG image. OK? So now I have my index dot html.

What I need to do is go and create a bucket and we'll call this my cloudfront website and then let's make it unique. I will want some public access settings on this one. So let's acknowledge that the settings might result in the objects becoming public. We'll create the buckets and now I'm gonna go into the bucket.

The first thing I'm going to do is click on upload and add my files. So here's my files. I've got my index to html and the free images that I chose to be part of my static website. So I can simply upload those files now that the files are uploaded.

I'm gonna head over to properties, go all the way down enable static website hosting. So click on edit enable and then index dot html is the index document. We don't need an error document. So I just save the changes.

Then I'm gonna go to permissions, click on edit bucket policy, add a new statement for this one. I'm gonna backspace and then put in a star as a wild card for the principle for action. I'm going to put in S3 colon, get objects, then create a new line and I'm gonna put in resource colon and then I need to in inverted commas just pop, pop in the bucket A RN here. So let's put that in with a slash star on the end.

So that's my bucket policy. We have a wild card for the principal. We're going to allow get objects on the bucket with a slash star after it. All right, let's go ahead and save those changes.

So now I should have a static website that works. If I go back to properties to the bottom of the page, click on my link there for my static website. And you can see that I get those free images on the website. So there we are we have our static website showing the images.

We are now ready to go and perform some more steps to get this published through our cloud front front end. Now note that this is not secure, so it says not secure there. It's http, the static website endpoint is http not http, we are gonna fix that. So what I want to do first is go across to the certificate manager service here it is.

Let's open this one up and in the AWS certificate manager service, I am going to click on request a certificate. So we're going to request a public certificate. We need to know the fully qualified domain name of our domain. So let's head across to route 53 and just check the hosted zone name there.

It is DC T Lab, training.com. So let's copy this domain name. Best place is to come here, copy the domain name. You can see that in this zone.

I've just got two records, the name server and the start of authority records. So we don't, we haven't used this one yet. Let's come back to certificate manager. I'm gonna paste in the domain name.

I'm gonna leave DNS validation enabled. I don't recommend using email validation. Sometimes it's unreliable. So stick with DNS validation and then simply click on request.

Ok. So we've done that. Now, what we need to do is just refresh here, click on the certificate and we want to go to this option here, create records in route 53. So if I click this option, it's going to create these records.

It's a cname with a uh source and a destination value. So let's create those records or that record come back to the zone, click on refresh and you can see that cname record has been created. This is for validating the I own the domain. So what we should see now if we come back up a level is if we refresh and sometimes this can take a few minutes, but this should happen now.

So let's see. Yep, it's issued. So we've got a nice little green banner, the certificate has been issued. So sometimes that can take a couple of minutes once it's done, you don't need that C name anymore.

We can just delete that record, clean up our zone. Great. So now we have our certificate manager certificate. The next thing to do is to go ahead and create our cloudfront distribution.

So let's navigate to the cloud front service content delivery network. We're gonna create a cloud front distribution on the first page here. What we need to do is for origin domain, click on it and then you'll see that under S3. We have my cloud front website.

Now it picks up that this one is a static website and it's asking, do you wanna use the website Endpoint rather than going to S3 as if it's just a, a regular SS three bucket? Yes, I do want to do that. So I'm gonna use the website Endpoint we can see that the protocol here is http because remember the static website only supports HTTP. However, with the certificate, the cloud front distribution will serve HTTP S so what we want to do, we'll leave the name of the origin.

We'll leave all the defaults here. We'll come down and leave the defaults again. Scroll down further. This is the caching settings.

We'll leave it on caching optimized and keep coming down. We do not need security protections. Here we go. We've got the certificate.

We do need to enable a certificate. So I'm gonna choose the AC M certificate. OK? So DC T lab training.com, whatever your domain is you can put that into here.

Now, we don't need the default root object for a static website. We know what it is. It's been specified in the static website configuration as index dot html. If you use a regular S3 bucket, not a static website bucket, you do need to enter index dot html in here.

Now, the other thing I need to do, I've sometimes missed this one but here it is alternate domain name. So this is where we need to put in DC T lab training.com. That is the domain name that we want our users to be able to utilize to connect to this cloud front distribution. So we've got the alternate domain name, we've got the SSL certificate.

Now, all we need to do is create the distribution cloudfront distributions. Take several minutes to create. So gotta be a little bit patient while that's happening. We have been placed onto this page where we can see a bit of information so we can see the distribution domain name.

So if we're not using a custom domain, you can use this one and connect directly to the distribution here, we can see the deploying status here. So that's what's happening. It's currently in the deploying mode. So we won't be able to do much with it.

There are some security settings here where you can enable web application firewall or geographic restrictions. We've got one origin, you can add additional origins. So in this case, we just have one origin. If you have multiple origins, you can actually use things like behaviors to direct the incoming traffic to specific origins based on.

For example, the type of file or the path that's being used, you can configure your error pages, you can invalidate objects from the cache tagging and so on. So we just gotta wait a few minutes while that's happening. I'm gonna come back to route 53 and create my alias record. So I'm gonna create a record.

I'm gonna leave the record name because I want it to be DC lab training, not a subdomain. Now check this box here. So just flick it across alias and we want an alias to a cloud front distribution. We don't need to specify the region it's actually specified for us as us East, North Virginia cos that's where the cloud front distributions are created.

Then we just need to select our distribution. We'll leave simple routing and create the records. Always w wait until the status changes from pending to N sync before you attempt to use the domain name. Otherwise, you could end up with a negative cache somewhere um in your computer or upstream.

And then that means that you have to wait a little while for uh to be able to connect. So just wait until it says in sync. It usually doesn't take more than a couple of minutes. Anyway, we're still waiting for the cloudfront distribution that will take a little bit longer.

Ok. So it's been a couple of minutes. My record is now created, it was in sync and my cloudfront distribution appears to be deployed. So I'm simply gonna try and navigate to DC T Lab training.com and I wanna do so using a certificate.

So let's make sure that we have http S in the request here and then go to D CD lab training.com and there we go. Now, we have a website. So we have a website. It's been secured with a certificate which comes from the AWS certificate manager service.

So what we've done is we've created a cloud fund distribution with an S3 bucket configured as a static website. That's the origin. We created a certificate using certificate manager and an alias record using route 53 and now we have a secure connection to our S3 bucket. Now, the last thing is just to clean this up with cloudfront distributions.

What we need to do is select the distribution and disable click. Disable again. And that takes a few minutes. You'll need to come back once it's finished disabling and then delete it.

The other thing is to clean up records in route 53. I like to delete my A records, my alias records once I've finished with them, do not delete the NS or so A, they're very important. Do not delete your zone either. And let's come back to certificate manager and in certificate manager, I'm gonna leave this certificate myself because I find these certificates very useful.

This is an SSL TLS certificate for my domain name and I can use it over and over again with different services. So I will just leave that one where it is and that's it for this lesson.


### 76. AWS Global Accelerator

In this lesson, I'm going to cover Aws Global Accelerator and let's start off with a diagram to help you understand what this service actually is here. We have low balanced solutions. So we have some kind of application sitting behind a low balancer in us East one and Eu West one. So two different continents here, users in the US want to access this application and we can assume here that the application is identical behind these two regions.

These are here for high availability and redundancy. So users in the US speak to Amazon route 53 to resolve what DC T labs dot com's IP address is OK. So route 53 is the DNS service being used here. Now, what's gonna happen here is route 53 responds with these two answers.

OK. These are two static public I P addresses and these are actually called any cast IP addresses more on that in a moment. So now the users know that they can connect or the computers know that they can connect on these IP addresses. What happens next is the user traffic is going to ingress using the closest edge location.

So Global Accelerator is utilizing the Amazon cloud front network of edge locations and there's hundreds of those around the world. So these users are somewhere in the US. So they're gonna get directed to an edge location, somewhere close to where they are physically located. That means the shortest distance possible to get into the AWS global network.

And once they're in the AWS global network, of course, the latency is more consistent, the bandwidth is good. So that's why we wanna leverage the, the Aws Global network here. So the users get directed to the edge location and then from there Global Accelerator which is listening on these IP addresses is able to accept the incoming traffic and then it chooses where to forward it. Now, I mentioned that there's something called an unicast IP address.

What does that actually mean? So normally we're talking about unicast IP addresses, broadcast IP addresses and multicast. Now the IP that's associated with, for example, a web server that's a unicast IP address and it's actually a attached to a single network adapter somewhere in the world. It's not going to be in multiple lo lo places at the same time.

So if you have a web server that has a public IP address, it's physically located somewhere in the world. But what we wanna do is we want to have two public IP addresses that are identical for anyone anywhere in the world to connect to the edge location that's closest to them that's how we use an any cast IP address, which actually the routing across the internet is gonna forward you to the closest locations. So it's kind of like those addresses are actually physically present multiple places in the world depending where you are, you get directed to the closest one. So Global Accelerator then utilizes the global network to forward the connections to the relevant regions.

Now, in this case, the green line indicates where the traffic actually has gone. The purple line is purely the AWS global network. So those are potential paths but the users have been directed to us East one because they are in the US and therefore U SS east one is closest to them. This is routing to the most optimal end point.

So this is a healthy end point, it's closest to the users. Therefore, the traffic has gone there because that would be the best performance for those particular users. Now, if for some reason that site fails or the low balancer fails or something like that, then those users will be reconnected to another region. So the next best or the next most optimal region, which in this case is Eu West one.

So that's us as being redirected to another healthy endpoint and you there could be more endpoints available as well. Here we're just showing too. So this service operates at the network layer. So it's layer four of the O SI model.

It provides static IP addresses as a fixed entry point for your applications. Those are the any cast IP addresses and you can bring your own as well performance. It improves performance by leveraging the AWS global network backbone, reducing network latency for people around the world. It performs health checks to check that it's routing traffic to the most optimal and healthy endpoints and it supports TCP and UDP traffic.

So you can use this for a wide variety of different applications with cloudfront. For example, you're only able to utilize HTTP and HTTP S you cannot run traffic through cloudfront. If it's using some custom TCP or UDP port, that's where global accelerator comes in. In terms of use cases, it's ideal for non http use cases.

So for http and http S traffic port 80 port 443, utilize Amazon cloud front for anything else you can utilize AWS global accelerator. So global accelerator can then be used for a variety of different use cases where you're using any TCP or UDP port.


---

## Part 10: Containers and Serverless Computing


### 77. Introduction

Hey guys and welcome to the section on containers and serverless computing. This is probably one of the most interesting areas of Aws. And you could arguably say that the serves computing with advent driven architectures is really how you can get the best value out of the Aws cloud building cloud native applications that utilize various different services which Aws provide for us and manage for us as well. So we're gonna start off with containers essentially, this is using the Amazon Elastic container service and Aws Fargate to launch docker containers on Aws.

Now, if you don't know what a docker container is, don't worry, I'll get started by talking about what containers are, what the benefits of containers are and how we can utilize them in what we call micro services architectures. Then we get into servers, computing serves just basically means that Aws are managing everything for us so that we have less to manage. So we just bring our code, we integrate services together without ever having to worry about managing the underlying operating systems and compute platforms on which the service is run. Now, the hands on in this section are really interesting.

You'll get to deploy a service event driven architecture on Aws and a multipart series as well as practicing with some of the other services as well including containers and Aws. LAMBDA, one of the foremost services on A W SS. So have fun and I'll see you in the next lesson.


### 78. Docker Containers and Microservices

Hey guys. In this lesson, I'm gonna cover Docker containers and micro services. And this comes before we get into the Amazon Elastic Container service, ecs because ECs is a way that we can run these Docker containers on Aws. So firstly, what is a container and how does it compare to virtualization?

So we've already seen the virtualization stack that is a server with a hypervisor layer on top which creates a layer of abstraction so that you can run multiple virtual servers or virtual machines also known in AWS, of course as EC2 instances. So here we have a virtual machine which has some virtual hardware and of course it has an operating system windows or Linux for example, and then some kind of application service or website running on top of it. Now that all needs maintenance here, we have to maintain the operating system, we have to maintain the application. So every VM every instance needs an operating system and that also has a significant amount of overhead.

If you can imagine that on this virtualization platform, maybe on this one hypervisor server, we could be running tens if not hundreds of virtual instances on top and that's a lot of overhead because each of those has its own operating system, it's a lot of maintenance as well. So here we have a container stack, so we still have a server underlying it. We then have an operating system could be. Linux could be windows on top of that operating system, we run the Docker engine.

So here is a layer of software. So now we have a type of a bit like a hypervisor. We have some layer of abstraction on top of which we can run the containers themselves. So now what we do is we run our containers.

Each container includes all the code settings and dependencies for running the application. But it's not an operating system instance, there's only one operating system here, but we're running multiple containers. Each container is isolated from other containers. So you can see we're running lots of different types of applications.

The containers start up really quickly much faster than an instance would on EC2 for example. And that's because there's less to start up. You're not booting up an operating system which can take sort of significant time. So here we have lots of different containers and they're all very resource efficient compared to virtual machines because we don't have that overhead of the operating system.

So they use less resources and they start up much faster. Docker utilizes containerization to package an application and its dependencies into a single container. Image docker also provide the Docker hub, that's a cloud based registry service where you can store and share your container images and automate workflows for deploying those images, containers are lightweight because they share the host systems kernel. So that part of the operating system, which of course utilizes quite a bit of overhead on the server itself.

So Docker is ideal for micro services architectures and building cloud native applications. So what exactly are those? Well, here's an example of a cloud native application with cloud native applications. We're leveraging the best of the cloud.

So we're able to deploy things like micro services architectures where the applic are constructed of loosely coupled components. That means that we're separating different components of the application and deploying them individually. Here, we can see we have the customer service that's actually running on Amazon ecs. So this is Docker containers, what we're talking about in this lesson, but you can also run LAMBDA functions as well.

Those could be separate parts of your application. So a segment of the code here is the shopping cart. This is running authentication. This one here is the customer service component of the application.

And then we've got the payment gateway. All of these are running separately from each other. So we're utilizing containers and functions. The code is running in Docker containers and lambda functions where it's isolated, it's elastic and it's cost efficient.

If we have to update any individual component of the application, then it doesn't affect the other components of the application because they're separate. We have programmable API based inter service communication through API S. We're leveraging things like message queues for storing information as it's passed between different components of the application. We're utilizing a rest API here, we're utilizing things like dynamo DB tables and notification services.

So we're leveraging all these different components of the cloud to build this cloud native application. It gives us a lot of advantages both in cost security elasticity and also from an operational perspective in terms of things like updating our applications because we have these separate micro services. So some of the attributes and benefits of using micro services are we get to use API. So everything in the cloud has an API that means we have those common languages that we can write into our code in order to integrate the different components of our application and loose coupling so that we're separating those components.

So they don't have those close interdependencies on each other. We have independently deployed blocks of code that means that they're separate from a maintenance perspective and scaling is separated as well. Some components of our application might have more traffic than others and they can scale easily and elastically and independently. We have a business oriented architecture.

So we're deploying around different business capabilities. It might even be different teams that are deploying different components of the application and they might be using their own programming frameworks that are separate and different to each other. Therefore, with the API S, we can still integrate together. Despite the fact that we have some different teams going through different operational processes and using different programming languages, we have flexible use of technologies.

So each micro service can be written using different languages. That's what I'm talking about just then where you can have different programming languages in a different component of the application. But because we can speak with a common language, that is the API that doesn't matter and speed and agility, so very fast to deploy your components of your application utilizing cloud native features. And it's very easy to building high availability and fault tolerance.

A lot of that comes from the underlying infrastructure that AWS deploy services like LAMBDA functions. They already are highly available for us. So all we have to do is set up how we wanna be able to scale our functions to allow more concurrency and the same with running Docker containers on Aws using Amazon ecs. They have a serverless service which takes care of all the high availability for you.

And that's what we're gonna move on to next. We're gonna have a look at the Amazon Elastic container service.


### 79. Amazon Elastic Container Service (ECS)

Hey guys in this lesson, I'm gonna cover the Amazon Elastic Container service, Amazon ECs, which is a service in which we can run docker containers on AWS. So let's have a look at ecs and the various components that make up this service. So one of the most important ones is we get to deploy something called an ECs cluster. So we always have to create a cluster and then we can start looking at the various other components.

So we have a cluster and that is a logical grouping of tasks or services within the cluster. We can then launch our tasks and a task is a running docker container. So we don't just call it a container in ECs. We call it a task.

The task comes from a task definition. That's a very important component. We have to create a task definition that defines what it is we want to run. You can see this fairly simple container definition here.

The name is wordpress. So wordpress is the image that we're gonna pull down. It's gonna be a task that runs a wordpress website and it has a link to another container which is a my SQL container. So that's where the database layer is going to be.

We can see what the container port is. This is a website running on port 80 how much memory and CPU we want to assign to this particular task. So the definition of the task is defined in the task definition. And then when we launch a task, it's gonna utilize that.

Now, of course, there has to be an image. So the task definition actually defines what image we wanna pull the wordpress image. In this case, the image is stored in a registry such as the Amazon Elastic container registry. So when we start up our task, it's gonna pull the image from the elastic container registry based on what's defined in the task definition.

So we can store our tasks in ECR. Also, they can also be in other repositories like Docker hub as well. Now we can then deploy something called an ECs service. An ECs service is used to maintain a desired counter tasks.

So it's a bit like auto scaling with Amazon EC2 where we can say we want a certain number of tasks to be running. I always want to have 10 tasks running for example. And it's gonna make sure that it maintains that counter tasks. Now, there's a concept called an ECs container instance.

And depending on where how we're utilizing ecs this either exists or it doesn't, it doesn't, when we're using something called aws fargate, we'll go into the details shortly. But that's a serverless service, which means we're not managing any of the underlying infrastructure. If we're not using Fargate, we're using something called the EC2 launch type. And with that, we're actually deploying EC2 instances into our AWS account and those instances must have the ECs container agent running and then we join them to the cluster, those EC2 instances then become the hosts on which the tasks are going to run.

And we have to manage those instances. We can then add auto scaling for those container instances themselves. So the ECs service is essentially the auto scaling for the tasks. And then Amazon EC2 auto scaling is being utilized for the ECs container instances.

So let's have a look at some key features. We've got a surplus option with Aws fargate. That means you don't have to manage any of those ECs container instances yourself. It's managed for you and it's fully scalable.

It provides fully managed container orchestration. So the control plane is managed for you with EC SS, there's docker support so you can run and manage docker containers with integration into the docker compose command line interface. There's also windows container support as well. ECs has integration into elastic load balancing.

So we can distribute traffic using A L BS and NL BS. These are defined as part of the service. So when you create a service within ECs, you can define a load balancer. There's another service from ECs called ECs anywhere which enables you to utilize the ECs control plane with on premises implementations.

So the core components of ECs are these, we've got the cluster. That's the logical grouping of tasks or services. We've got the container instance only relevant if you are actually utilizing the EC2 launch type rather than the Servius Fargate launch type. Here, it's EC2 instances running the ECs agent in your account.

Then there's the task definition. This is the blueprint that describes how a Docker container should actually launch. The task is the running container based on the settings in a task definition. And it needs to pull an image from ECR or Docker hub for example, which is the image that's referenced in that task definition.

And then lastly, we have the service which defines long running tasks and enables us to define a task count or use auto scaling and also to attach elastic low balances as well. A bit more detail now on ECs images. So containers are created from a read only template called an image and that has the instructions for creating the docker container. Those images are built from a Docker file and only docker containers are actually supported on ECs images are then stored in a registry such as Docker hub or Amazon elastic container registry.

And ECR is a managed Docker registry service that's secure, reliable and scalable. ECR also supports private Docker repositories with resource based permissions using I AM in order to access those repositories and the images within them, you can also use the Docker cli to push pull and manage your container images, moving on back to tasks and task definitions. So the task definition is required to run docker containers in Amazon ecs. And it's a text file written in JSON format that describes one or more containers up to a maximum of 10 task definitions, use docker images to launch the containers and the image name is referenced within the task definition itself.

The two different launch types are EC2 and and Fargate. Very important to understand the differences between these. There's quite an impact in terms of what your costs are gonna be, how you manage your infrastructure on ECs. So firstly, we have the EC2 cluster.

This supports registries including ECR Docker hub and self hosted for the EC2 launch type. You explicitly provision EC2 instances into your account. They have the container agent installed, they need to have the right permissions for ECs and you need to join them to the cluster. You're then responsible for managing those EC2 instances and you're charged per running EC2 instance.

So you don't get charged with the number of tasks running on the instance, you're just charged for the instance itself. So you've gotta work out there. What whether that's more cost effective compared to the Fargate launch type, it supports EFS FSX and EBS integration for storage. So quite a few storage options there and you're gonna handle all the cluster optimization.

So for example, scaling the container instances, but you get more granular control here over your infrastructure, we then have the Fargate launch type. This supports ECR and Docker hub for registries. With the Fargate launch type. It automatically provisions the resources for you Fargate provisions and manages the compute and you're charged for the running tasks.

So it's a per task charge this time. Instead it only supports EFS for integration and Fargate will handle all the cluster optimization for you. So this is a serverless service as you might expect with a serverless service. Of course, you have less control.

So here you have to weigh up the two different types of launch type of workout, which is best for your particular use case. We need to provide permissions to our container instances and our tasks for the container instance, we can attach an instance. I am roll the container instance, I am roll provides permissions to the host. And here's an example of a managed policy that you can utilize to create this role.

So this provides some permissions to ecs. So it means that the EC2 instance that runs the container agent is able to then access the ECs service. Then we need to supply permissions to our tasks for that we can utilize a task I am role. This provides permissions to the container itself.

Now it's important to note that with the Fargate launch type, the container instance, role is replaced with a task execution role which provides the permissions to execute the task. But we still need to use the task. I am role in order to provide the permissions to the task if that task needs to access other aws services like S3 for example, or a dynamo DB table.


### 80. [HOL] Launch Docker Containers on AWS Fargate

Welcome to another hands-on lesson in this lesson. We're going to deploy a docker container on the Aws Fargate serverless implementation of Amazon ecs. I've navigated across to the elastic container service. And what you should end up on is a page that looks like this or you might end up on the clusters page directly sometimes.

So either way you can click on clusters on the left hand side. So the first thing to do is to create a cluster, then we're gonna create a task definition and then we'll be able to launch tasks into our cluster. So back up at clusters here, I'm going to click crate cluster, I'll give it a name, my dash far gates cluster with dashes. And I'm gonna choose Aws Fargate.

It's the default here. So we're gonna use the Servius option, which means that it's gonna scale for us automatically. Otherwise you can choose to use Amazon EC2, then it's a manual configuration and you've got external instances using ecs anywhere. So that's all I need to do here.

I'm gonna click on create now, what should happen is it's gonna go across to cloud formation and build our cluster. You can click on view in cloud formation. Word of warning. When you first use ecs, it might fail the very first time if it does delete the cloud formation stack, come back to clusters, create it again with exactly the same settings and it should work the second time.

I don't know why that happens that way. It's been like that a long time. And nevertheless, um that's the problem that we have to deal with. So in this case, it looks like it's working.

So it shouldn't take long for our cluster to be completed. There we go. We've got to create complete now. So I'm gonna head back to clusters.

Don't need cloud information anymore. We've got our cluster ready. OK. So here it is under cluster overview.

Here, we've got the overview information, then we've got services. So here we can create a service. If we want to do, find the number of tasks we want to have running tasks is where you can launch an individual task. That's an individual container infrastructure is not relevant because we're using Fargate.

But with ecs, uh when you're using the EC2 launch type, then you can manage your infrastructure here. We'll have some metrics and you can do schedule tasks as well. So what we want to do is we're gonna launch a task, but we need first a task definition. So on the left hand side, we're going to navigate to task definitions, create a new task definition and I'm gonna call this one engine X dash container.

It's gonna be the engine X image that we use. So that's the task definition family. Then we've got the launch type. Of course, we want this one to be compatible with Fargate.

We don't need to select EC2. So don't select that option. Just leave Fargate selected. I'm gonna leave the default here for the CPU and memory task roles allow the containers in the task to make API requests to AWS services.

So if you are going to allow your container, the task itself to call any API actions on any other services, then you'll need to specify a task role here. We don't need one. In this case, the task execution role, this is used by the container agent to make API requests and it's gonna create a new role for us. We don't need to specify task placement as you can see it's not supported for Fargate.

So we just come down to container and again, I'm gonna call this one Engen X dash container and then the image is gonna be Engen X colon latest to get the latest image for resource allocation. You can go ahead and sort of set limits here if you wish to. I'm gonna leave those as the defaults port 80 is correct because this is going to be a web server. So let's just scroll down log collection is very useful.

So I'll leave that selection uh that selected so that we can actually go and have a look into cloud watch logs if we have any issues. So that's it. All I need to do here is just click on create and that's gonna create my task definition. So what do we wanna do next?

Now, we wanna come back to our cluster, select the cluster, click on tasks and then run a new task. Now this one is gonna be Fargate. Of course. Latest here we're gonna select task, choose the task definition family engine X container.

I'm gonna have one car task under networking. It's, it has the default VPC selected, our default VPC should have a public IP setting enabled. So the instances do get public IP si do wanna select a security group. So I'm going to select my web access security group, which is in the default VPC, public IP is on and that's all I need to do.

Let's create the task and let's see if it starts running tasks should start very quickly. So it shouldn't take long. If it takes a long time, there's probably a setting that's been incorrectly specified. And there we go, we now have the task in a running state.

So it didn't take long to launch it. We can see the task definition it was launched from. We have a task ID here. If I click on the task ID and head over to the networking tab here, we've got the public IP.

So I should be able to copy that and put it into my clipboard. And there we go, we get a simple welcome to engine X splash screen. So that's working. I've now launched a task using Aws Fargate.

Now, the other thing we can do is let's stop this task. So I'm just gonna stop the selected task, press stop again and that one's gone. The other thing we can do is create a service. The service allows us to specify the amount of instances or the amount of tasks that we want to have running here.

We can choose Fargate again. Scroll down this time. We're selecting service engine X container and we can give it a name. And let's just call this my dash service.

Very simple. And let's just up this to two tasks. That's how many we want running at any one time. And then again, we have to just check the networking.

It's gonna add the default security group. I don't want that. I want to choose my web access, but I'm happy with the Subnet and VPC to public IP is on again. Now, the service is where you then add things like load balancing.

We're not gonna do that now. But if you had a load balancer, then you could go and add it in here. So now you can load balance the incoming connections to your backend tasks. There's also service, auto scaling which you can enable as well if you want to adjust the desired count based on performance metrics.

So I'm just gonna go ahead and create and this time once the service is ready, it's going to launch two tasks and it should keep two tasks running for us at all times. So we can now see the service here and it tells us that two out of two tasks are running. So if we head over to the tasks tab, here we go. We have our two tasks.

So very simple to use. Once you set up your task definition and your cluster, now you can deploy tasks very easily enable auto scaling, enable load balancing, whatever it is you need to do. So I've finished with this particular exercise. All I need to do for this one is come back to my service and I'm going to delete the service.

I can force delete to make sure it just deletes those active containers and press delete again. So that will delete the service. The cluster will need to be deleted separately. This is OK.

The error message, it's because we actually just deleted the service. You can delete the cluster. It doesn't cost you anything as long as there's no tasks running which they shouldn't be on my cluster now.


### 81. Serverless Services and Event-Driven Architecture

Hey guys. In this lesson, I'm going to cover Servius services and an architectural pattern known as event driven architecture with Servius, we don't need to manage instances. So we've moved away from the model where we need to launch EC2 instances and then manage them. And now we can spend more time on innovation.

You don't need to provision hardware. Of course, that's all done for you. Aws are managing the underlying infrastructure and there's no management of operating systems or software. So with serve us, both the operating system and the application are deployed for you and you're not worrying about things like the scalability of the underlying infrastructure or high availability.

All of that is taken care of for you capacity provisioning and patching is also handled automatically all of that becomes abstracted away. So you just need to bring your code or deploy the service and configure it in some way, automatic scaling is provided for you with high availability and it can be very cheap as well. Services like LAMBDA are extremely cost effective to use. So let's have a look at serve us with event driven architecture.

That's a pattern that where we can utilize services in such a way that an event in one is going to trigger an action in another service. Here, we have a static website and a user is accessing that static website running on S3 and performing some kind of action. In this case, the user is uploading a file through the static website. So the file ends up in an S3 bucket using a bucket configuration known as an event notification.

We can configure it such that when a upload happens of an object S3 is automatically going to notify a Lambda function. And the lambda function is then able to take that file that's been uploaded to the S3 bucket and process it in some way. So here the surplus function is processing the file and then maybe it's storing the results in another S3 bucket. Also that Lambda function may send a message to an SQSQ.

Remember QS are used for decoupling. So now we have a message in a queue and that message can be picked up by another service. Now couple of ways. One is that that s service that function or instance, for example, can pull the queue or through event driven architecture.

The queue can trigger the function to say message has been received. I know that I need to send it to a particular Lambda function that function might then process the information in that message and store the results in a dynamo DB table. So here we have an event driven architecture. The LAMBDA function might also use an SNS topic to send a notification via email.

All of this happens automatically, the user simply uploaded an object to a website. Everything else happened automatically, it was event driven. So an event that happened in one service triggered an action in another service. And here we have a whole chain of those actions taking place.


### 82. AWS Lambda

OK. So in this lesson, we're gonna cover Aws. LAMBDA. LAMBDA is perhaps the most well known serverless service with LAMBDA.

We have functions, a Lambda function runs some code in response to some kind of trigger. Here, we have a developer. The developer has packaged up some code in a zip file. We can use zip or wire file formats.

The code is then uploaded to the function. In this case, it's a simple Python script that runs through and logs and events are cloudwatch logs. So we've got some Python code. Now, the Python code has been added to the function at this point in time, nothing is happening and we're not spending any money, we've created a function but it's not actually running.

So we're not paying anything. Then lambda functions are invocative based on events and then the code is executed. So in this case, some kind of a some kind of trigger is causing the lamb to function to execute. The code pricing is based on memory assigned and the duration of the function execution.

So depending on the amount of memory you assign to your function, it allocates a proportional amount of compute power of CPU and you pay based on the amount of memory you assigned and how long the execution of the function lasted. In this case, this function is simply writing an event to cloudwatch logs with Lambda. It supports many different languages such as Java go powershell, no, Js C# Python and Ruby code. The execution role is an I AM role that provides the function with permissions, access other aws services and resources.

So for example, in the previous diagram, the Python code in the function was writing an event to cloud watch logs. That's only going to be possible if the function has permissions to cloud watch logs. So it's really important to make sure that your execution role for your function has the relevant permissions it needs. For example, if you want to write some message to a queue or you want to add an item to a dynamo DB table, all of that is going to require permissions that are assigned through the execution role for monitoring and logging A US lambda will integrate with cloud watch.

So you can see performance metrics as well as logs from memory and time out. You can specify the amount of memory allocated to a function. And of course, that dictates the price as I mentioned before. And the maximum execution time, the maximum execution time is 15 minutes for a function.

So you might have your code only running just for a few seconds or you can run it right up to 15 minutes. Let's have a look at function in vocation. So the function runs in response to events from various services through aws or direct invocation from the aws sdks or the API functions can be invoked either synchronously or asynchronously with synchronous invocation. Applications actually wait for the function to process the event and return a response.

So you see a success or failure response with asynchronous invocation. Lamb accuse the event for processing and then just returns a response immediately. So you don't really know the outcome of that function in vocation, LAMBDA will scale horizontally by running multiple instances of a function in parallel up to the concurrency limit. So here, if a function is invocative, it's gonna execute here, we can see that it's already got two invocations that have come in that are running in parallel to each other and then more can occur as well.

So here we have lots of different invocations of the fun running in parallel to each other. And we can run many of these right up to the concurrency limit. If we want our LAMBDA function to access resources within a VPC, we can connect the Lambda function to the VPC. So remember that functions are regional and they don't have access to a VPC by default.

So what we need to do is connect to the VPC. And what will happen here is we'll define the subnets we wanna connect to and Lambda is gonna create an elastic network interface in those subnets. Now we do of course, here need the function to have the relevant permissions for EC2 to create the EN I. So that has to be in the task execution role.

You must select the VPC, the subnets and the security group that those Enis are going to utilize. The function role needs to have the relevant permissions as I mentioned before and that gateway is required for internet connectivity. So maybe your lab, the function needs to access these applications in the private subnet, but maybe it also needs to check on the internet call, an API download something or some other operation. In that case, you need a net gateway for the function to now be able to route out of the VPC and back out to the internet.

So here we've deployed a NAT gateway in a public subnet. And now our LAMBDA function is able to access the internet via the NAT gateway and the internet gateway.


### 83. [HOL] Working with AWS Lambda

Hey guys in this lab, we're going to work with the server service, Aws lambda. We're going to create a function and we're gonna see how we can trigger executions of that function in a couple of different ways. In the course, download, you will find the Aws Lambda folder and this working with LAMBDA dot MD file. So make sure you've got this code ready.

What we're going to do first is we're going to go and create a Lambda function that logs a message to Amazon Cloudwatch logs and we have some Python code here. So what you'll want to do is copy all of this Python code from line 7 to 24. So I'm gonna copy this code now. What this code does is it simply writes an event to cloud watch logs with a message and so we can write a customized message and it's gonna s appear in cloud watch logs in one of the log files.

So back in the console, I'm simply gonna search for LAMBDA and there it is LAMBDA run code without thinking about servers. Great little tag line. So let's create a function in Lambda. And here what we can do is we can offer from scratch, choose a blueprint or you can even use a container image.

Well, we're gonna offer from scratch and I'm gonna give this one a name and I'm gonna call this right to Cloudwatch. Next, we need to choose the run time. We've got several different options as you can see. So what we're gonna choose is we're gonna use the latest Python.

In fact, the latest would be up here. Python 3.12 doesn't really matter. 3.93 0.12. Whatever the latest is when you watch this video, it could be different, shouldn't matter with this particular code sample.

So I'm gonna just gonna choose one of these runtime. Next, you've got the option for the architecture. We leave that on X 8664 permissions are really important to understand with LAMBDA. If you want your Lambda function to be able to interact with any other Aws services, you will need to supply permissions.

Now by default, it's gonna create a new role with basic Lambda permissions and those permissions will provide access to cloud watch logs. So I can just leave it as it is. Alternatively, you can use an existing roll or choose from various policy templates which you can find down here. So I'll just leave it on the default to create a new role with basic Lambda permissions.

We then have advanced settings. There's a few options here. We don't need to change any of those for now. So we'll just leave those selected or deselected at the defaults.

And let's create the function. Once the function's created, you're going to end up on this page here. What we can see is a function overview. We can see our triggers.

If there are any, we can see destinations. We're gonna go over these in just a moment down a little bit lower. We can see the code editor and it's just written some default Lambda code in here. The hello from Lambda.

What I want to do is delete that paste in the code, which we got from the document in visual studio code and then click on deploy. So that's gonna deploy my update. Now along the top here, there's a couple of really important places. One is configuration.

If we click on configuration, we can see there's lots of options here. For example, the default time out for our function is three seconds. We can increase that if we wish to. We've got memory here, 128 megabytes by default.

What I wanna show you is down in permissions. So permissions you can see there's a roll here and that roll has Cloudwatch logs permissions by default. If you need to add permissions to another service, you can always go ahead and edit the role also on the monitor tab. This is where we can click on cloud watch logs.

Once we've executed our function, I'm gonna use the test utility here. And what we're going to do is we're gonna create a test event. So back in this document here, we're gonna create a test event using this test data and it just says, hello Cloud Watch. So I'm gonna copy this JSON and back in the event, Jason here, let's paste this in, just call this my event and then I'm going to save and then run a test event.

What we see at the top here is a nice green banner which is saying that it's succeeded. And we've got a response here which says message logged successfully bit lower. We can see some more log output and there's some details here in the summary as well. So how long did it take to run?

Cos you get charged based on based on this per millisecond, which function version was used. Dollar. Latest is the editable version of the code that we just where we just uh entered our code a few moments ago. You can then publish different versions as you make changes as well.

And we can see the log output here. So this should be in cloudwatch logs. So you can click here or remember, you can come up to the monitor tab and then click on view cloudwatch logs here. So now we can see this log stream.

I'm gonna click on the log stream, open up the log stream here and we can see our message. Hello, cloud watch and there's a few events related to that individual execution, telling us when it started, when it finished, we've got a report and then we have the information in the middle there. So that all worked nicely. If I come back to the file here, what we want to do next is see how we can do the same thing from the command line interface.

What we're going to do is use this test data. We need to create a file called payload dot JSON. And then we're going to run this command to invoke our function. So first, I'm going to copy this JSON data.

Let's open aws cloudshell. And I'm gonna create a file called payload dot JSON, paste this data in and then simply save that file. So now I have my file next, we want to run this command, but we need to update our function name. Mine's called right to cloud watch.

Next, you'll want to copy this entire command from where it says AWS down to the letter N after JSON. Now the file B indicates that it's a binary format, which is what we want here. So the file, the B on the end here under after file is not a Typo, don't edit that out. So then you want to paste this in and let's try and invoke our function.

Now we have a status code 200 that is a success code and it does say the dollar latest was executed that's the latest version of our function. So what I want to do is come back to cloudwatch here and let's just see if it's created a new log stream. No, it's the same log stream. So let's just expand.

And what we should see now is we should have an additional event where it says hello from CLI. So that's work. We've now executed the function both using a test event in the console. And then we've used the command line interface with the AWS lambda invoke command to invoke our function.

Next, I'll show you how we can trigger the function using an event notification from Amazon S3. So what we're going to do now is we're going to upload objects so files into an S3 bucket. And when we do that, an event notification in S3 is going to let lambda know that something's happened and LAMBDA is gonna pick up the name of the file and associated metadata and it's gonna put that into cloud watch logs. So we have a slightly updated version of our code here.

What we want to do is copy all of this code and back in LAMBDA. Let's go over to the code page, delete all of this code, paste a new code in and then deploy. And so now we've updated our code now we will need permissions to Amazon is free. So I'm gonna go over to configuration permissions, click on the roll name and for the permissions policies here.

All we have is basically access to cloud watch logs. So what we're gonna do is attach a policy. If I type S3, I need read only access and then let's add the permissions. Ok?

So now the function has permissions to read from cloud watch logs. So what we can do, we've got the code installed. Let's add a trigger. So if we add trigger and choose source S3, now we need a bucket.

So make sure you've got a bucket. Let's have a look at what I've got and what's in my buckets. So if I head over to S3, I've got a few from previous exercises. Anyone will do maybe this one, my bucket.

Ok. That's got a couple of documents in. It doesn't matter if there are things in there already and it doesn't have to be publicly accessible. So you could just create a new bucket.

In fact, let's do that. So, uh everyone's doing exactly the same thing. So this is my event notification test bit of a long name to make it unique and we don't need to make any changes whatsoever. So we'll create the bucket and then we can come back to triggers here.

I'll give it a refresh. So it should pick up my new bucket. Next. We're gonna leave the default event types here because this is what we want object, create events.

I don't need to set any other settings here. I'm just going to acknowledge this warning here and click on add. So now we can see that we have the trigger. If we go back to the bucket and click on the bucket and go to properties, scroll down a little way, we'll see that an event notification is being created so you can create this configuration through this console as well.

So now what should happen is if we upload objects to the bucket, it should execute the code automatically via the trigger. And then we should see an event in Cloudwatch logs that includes the name of the file we uploaded. So I'm just gonna go and upload a file. Let's choose one of these ones.

My pineapple for example and click on upload. I'm gonna close. Let's do the same again. Add a file this time, I'm going to add my Papaya file.

You can add anything you want, doesn't matter what type of document. So what we need to do now is go and check if this work correctly. So I'm back in lambda. Let's go to monitor.

In fact, I've already got Cloudwatch logs open, but don't forget you can always come and find it from the monitoring tab. Now, in Cloudwatch logs, I'm gonna go back up a level because I suspect that it would create a new log stream which it has. So if I click on this log stream and then expand, we can see there's a whole bunch of metadata associated with the file and the event, it's an object created, put API action, we've got a source IP address. We've got information including the bucket name here and the key.

The key is of course the file name. But now our code specifically prints out the file name as well. So we can see that right here and you can see a couple of different entries where two different objects were up uploaded to Amazon entry. So now we are not just manually triggering it through the cli or the test event, but we're also having it automatically triggered through an event notification as well.

So that's it for this lab. Feel free to clean up those resources. You can simply delete your function in your bucket, but you won't be paying for Lambda functions when they're not being used and you're not gonna go through the free tier with a few test events like this anyway. And S3 does have quite a good storage limit uh for the free tier as well.


### 84. Application Integration Services

Welcome back in this lesson. I'm going to cover application integration services. So as the name suggests, these are a set of services that are used for integrating different components of our applications, whether they're server based or serverless. So let's have a look at an event driven architecture where we utilize some application integration services.

Here, we have an ecommerce website. User places an order through the website. The website in this case is running on E two. Now this event, the all are being placed on the website causes a couple of things to happen.

Firstly, Eventbridge is triggered. So a rule in Eventbridge is going to route some information through to the simple notification service to notify the customer that the order has been submitted. So here SNS is sending the email out. Meanwhile, the information about the order is placed into an SQS queue.

So the simple queue service is being used here. A message goes into the queue with some information about the order. Couple of things can happen here. Either the act of the message being placed in the queue can cause a trigger which is to trigger lambda or you can configure lambda to constantly pull the queue and check for new messages.

In this case, the SQSQ is configured to trigger LAMBDA and LAMBDA will then store some results of the order in a dynamo DB table. So that's an event driven architecture where we're connecting things together with application integration services. In this case, Eventbridge, SNS and SQS. Once the order has been completely fulfilled, Lambda might also use SNS to send another email to the customer notifying them of the order fulfillment.

So let's get started with a bit more detail about SQS. Here we have a direct integration between two components of an application. Now this is fine for some use cases, but there is a problem with this and the problem is that we have these two autos scanning components of the application. What if one of them can't keep up with the workload?

So maybe the web tier is receiving a large number of orders and the auto scanning group on the back end, the app tier needs to scale and that takes some minutes during that process, there could be some orders that get lost if you have this sudden spike in activity, that's a problem. So what we can do instead is put an SQSQ in the middle. Now, the EC2 instance is polling the queue. So that's the app tier checking for messages that have been placed by the web tier.

Now, it doesn't matter if the web tier suddenly gets a huge spike in orders and that information just gets put into the queue. In this case, the app tier can process those orders when it's ready to. And if that requires some scaling and that requires a bit more time, that's better than losing those orders completely. So here we have what we would call a decoupled integration.

Let's have a look at SNS. This is the simple notification service. The difference is SNS is more of a push based service. It's a publisher subscriber model.

We create something called a topic, we then have subscribers. So for example, for an email, it could be something like a newsletter. You could have one or thousands of people subscribing to your newsletter. And when you send it via the topic, that email goes out to all of those different subscribers.

But likewise, it could also be Lambda could be SQS could be some other web application. There's a variety of different targets who can be subscribers for a topic. So the information is then sent to those subscribers every time a message gets placed into the topic. Again, we can pass information from one component of an application to another.

And it supports various transport protocols like http email, email, JSON and S MS to name just a few. So this is another example of decoupling. This is more of a publisher subscriber model and it's where it's more push based SQS is more pull based. So typically instances or LAMBDA functions are polling the queue and checking for messages.

And with SQS, it's more 1 to 11 function or one instance is processing a message and that's done. In this case, one message goes out to many subscribers. Eventbridge supports many different event sources can be AWS services, custom applications or SAS applications. Some event happens in those sources and that information is then sent through to eventbridge, the event bus based on rules that we create is then going to forward that information to various different targets.

They can be, for example, LAMBDA functions, kinesis, data streams, SNS topics and so on. So there we have targets. So Eventbridge is a really useful tool. There's so much power that we can do with eventbridge and it has lots of built in integrations for AWS services and rules that we can create very easily through a graphical wizard.

So let's just compare some of these application integration services. SQ SS. I've just gone into a fair amount of detail there. That's a message queue.

So it's what we call a store and forward pattern and it's used for building distributed and decoupled applications. SNS is a notification service. So this is pushing notifications like emails or just information from one application component to another. But the end points are the subscribers and there can be many of them step functions is useful for coordinating and orchestrating workflows.

So for example, you can pull together lots of different lambda functions into an orchestrated workflow with some logic about how those functions are executed. Amazon MQ is similar to SQ and that it is a message bus, but it supports the open source Apache active MQ and rabbit MQ. So if you're using those industry standard API S and protocols, many users or many companies will use these on premises, then migrating into the cloud is easier if you wanna keep using those same tools for your message buses. So that's where Amazon MQ comes in.

And then lastly Eventbridge, a serve event bus for connecting lots of different application components together. Now these are some of the core application integration services. There are others, of course on Aws.


### 85. [HOL] Serverless Application with REST API – Part 1

Hey guys, welcome to this hands on lesson in this lesson. We're going to start building a surplus application. This server application is gonna have a rest API and that's gonna be part of the web front end so that we can actually access our application from the internet. Now, this is part one of two parts cos we're gonna break it up as we need to go and learn a few more concepts before we finish this lab off.

So basically what we're gonna end up with when it's complete is a static website and we can submit orders through our browser. So the static website is a similar order submission. Imagine it's an ecommerce application that order will then be forwarded through to a rest API running on Amazon API gateway. The API will proxy the request to a lambda function.

That means it just forwards it through without actually modifying it. In any way. The lambda function will then take that order information that's been submitted and place it in an SQSQ so that a different function and that function is the processing function can process the message and place it in a dynamo DB table. So now, the order information ends up in the dynamo DB table.

So here we've separated with a queue. So of course, we're decoupling. That means if the processing, for example, takes a lot longer, then it doesn't impact the orders coming in and getting placed into the queue. So the final result is we have a record of the order added to the table and we'll be able to see that.

Now, we haven't learned API gateway yet. So what I want to do is just show you the pieces that you have learned. So we're gonna build this part of the application and rather than have the API front end, we're actually gonna submit a request through via the CLI and via the Lambda console as well. So that we still end up with a message added to the table.

The whole application works except the web front end and the API will be added on later on. So we're simply gonna be submitting our test events via the console and invoking our Lambda function via the CLI. OK. Let's go and build this out in the course.

Download in the Servius App directory. You'll find a few files, the Servius App instructions, mark down file the index dot html and then two Python files which are the submit order function code and the process order function code. So we're gonna use the instructions here. The first thing we need to do is create a Lambda function.

We're gonna call it, submit order function. We're gonna use the Python 3.9 run time and we're gonna add the code from the submit order function dot py file. We also need to provide SQS full access permissions to the execution role. So I'm gonna head over to Aws lambda.

Let's create a new function. Provide the name, submit order function. And it is important that you follow the naming. And I'm gonna choose Python 3.9 and create that function.

Now that the function's created. Let's go and grab our code. So we're gonna go to the submit order function dot py file and I'm going to select all and copy this function code. Now what we have here, we've got some Python code.

We can see the online five, we have the SQSQ URL. So once we've created the queue, we're gonna come back and edit this here to add in the URL of our SQSQ. And what this is basically going to do, this function is going to receive information, some order information in a specific format and then it's going to place that information into the queue. So back in my function, I'm gonna delete all of this code and then paste in my code.

I also need to go ahead. Now I haven't deployed yet, by the way, because we're gonna add our Q URL in a moment. So let's go to configuration permissions and I'm going to click on the execution roll name here. So that will open it up in the I AM console in here.

I can click on add permissions, attach policies and type SQS and we're gonna provide SQS full access and then add those permissions. So now the function role has the relevant permissions. Let's go ahead and create our queue. That's gonna be the next step.

So I'm gonna open the simple queue service back in the instructions file. We do have a name for the queue here. Product orders Q and we're gonna copy this into line five of our submit order function code. That's all we need to do with the queue in SQS.

Let's go and create our queue. We're gonna use standard. We're going to supply the name for the queue and that's it. We don't need to change any other settings.

All the defaults are fine for this particular use case. So once you've clicked on create, you'll then see that we have the URL here. I'll copy the URL, come back to my submit order function head across to the code tab. And then here we're going to just paste in this URL and then deploy the function code.

So now we can actually test that. This works. What I wanna do before I have the next function processing messages straight from the queue. I wanna show you that the message ends up in the queue.

So what we're going to do is we're going to submit a test event with this data, you can change the test product to something else if you like. So I'm just gonna copy this JSON code and back in my function here, click on test, create a new test, event, test order and then I'm going to paste in my JSON code and then all I need to do is save and then run test. Now it looks like it's done the job we can see here, we get some responses and it says order submitted to queue successfully. Now let's head across to the queue and I'm gonna click on send and receive messages.

And in here we can click on poll for messages and you can see straight away it found a message. If I click on the message, we can actually see the body. OK? So there might be some more information on the details there.

But this is the information. And our second lambda function is gonna pick up information in this format and place it into a dynamo DB table and this message will be processed as soon as we set that piece up. So let's go back to our instructions and see what we need to do next. We've run a successful test that all worked.

Now, we're gonna create our processing function. We're gonna provide this name. It's gonna be the 3.9 Python runtime again. And we're gonna use the code from the process order function file.

This time, we need both SQS and dynamo DB access. So coming back to LAMBDA, let's head back up to functions. Create a function. I'm going to supply the name, make sure that I choose the correct run time.

Python 3.9 and then create the function while that's creating, I'll come back, go to my process order function here. And I'm going to copy all of this information noting that I need to update my dynamo DB table. Once I've created it back in Lambda, I can remove all this code from the Lambda function here, add the new code in and then let's go across to configuration permissions, click on the role name and we're going to add the permissions we need. So what we need is SQS cos we need to pick up the message from the queue and Dynamo DB because this function is gonna place the information into the dynamo DB table.

So let's click on add permissions. We now have our permissions policies. So what we need to do is come back to the instructions and we're just gonna check what the table information is gonna be. So here we have product orders and order ID.

OK? So this is the name of the table. This is the primary key. Make sure you get the capitalization correct because it is very important.

So I'm just gonna copy paste. So we're gonna come back to the console, search for Dynamo DB. It's very simple to create a table in Dynamo DB. We simply click on the create table button paste in the table name, I'll copy the primary key, paste in the primary key.

And again, we can leave all of the defaults here, create the table and very, very quickly the table should be ready for us. So there it's creating and within a few seconds it's become active. OK? So now we have our dynamo DB table ready.

Now we do need to copy the name of the table here. And what I want to do is come back to my function process order function here. Click on code. We need to go where it says your dynamo DB table paste in the name and then deploy.

Now at this point, we have all the high level components. We have the functions, we have the Dynamo DB table, we have the Q. However, the only thing we haven't done yet is integrate the Q with the function. What we want is for the Q to trigger the lambda function.

So back in SQS, I'm gonna click on the queue to come back up to this level. Choose lambda triggers. And we're going to configure a lambda function trigger and we're going to choose a function and it's gonna be the process order function and then click on save. OK?

So that's gonna create, it says about one minute, usually a lot faster than that. Once that's ready, then we have the integration so that every time a message goes into the queue, it's going to automatically trigger the function. So the function doesn't even need to pull the queue. In it case the queue is sending a notification to say there's something waiting for you.

So now the function will automatically process the message from the queue. So there we go, that's enabled. Let's see if it actually took the information that was already placed into the queue and it did. So there, there it is.

My test product has actually been added to the table. We can also go ahead and test using the invoke function command from the command line as well. So what we're going to do here is we're gonna run a second test and this one is gonna be using the cli and cloudshell. So we'll open up cloudshell.

We're gonna create a file called input dot JSON and it's going to have test product two here, quantity two. So I'm gonna open up the cloudshell console. I'm gonna use NANO to create a file called input dot JSON. I'm gonna paste in my input there and then we're gonna come back and what we need to do is run this invoke command.

And of course, I need my function name. So I need to invoke the first function that is the submit order function. So let's copy the function name, paste this in and then we're going to invoke the function. The payload is in binary form, the file B colon slash slash input dot JSON and then the output goes there to record the success.

So let's just copy the entire command. And back here in cloudshell, I'll just run this command to invoke the function and we get a status 200 which is always good news, come back, refresh. And now we have the second product that's added into our e-commerce table. So at this point, we have the submit order function, we have the queue, we have the process order function and the dynamo DB table.

And we've submitted events from the cloudshell cli as well as test events through the LAMBDA function console. And those have both ended up in the table. So that's it for this lesson. When we pick it up again.

For part two, we're going to add the static website, front end and the API gateway so that we can publish this out onto the internet.


### 86. Amazon API Gateway

Hey guys in this lesson, I'm going to cover Amazon API Gateway. API Gateway is a really useful service and we've learned a bit about API S already. Of course, they are a fairly complex topic and I understand that for many new users, but I'm going to try and help you to understand API Gateway by giving, showing you a few diagram. And of course, we'll do a hands on lesson as well.

So let's have a look at an example of what we call a rest API with Amazon Api Gateway. So imagine that in a company, you have built some kind of application that is based on micro services and so that we therefore have multiple components of this application here, we can see we've got a lambda function for the booking service. We've got a lambda function for the payment service and we've got ECs containers for the account service. So we've got these three different micro services.

On the left hand side, we have a mobile application. So users on the internet with their access via a phone, have their mobile application and that mobile application needs to do things like viewing existing bookings for the customer submitting new bookings and using the payment service to accept the credit card and pay for the service and then the account service where they might be able to look at previous orders, get some help, things like that. So we've got these different microservices. Now, how does the application running on a mobile phone connected via the internet, connect to these different microservice?

Well, what we want is a single endpoint. So we want a public URL that we can direct the traffic to that's Amazon API gateway. So it provides the entry point, but also it knows how to actually co forward the requests to the various different microservices depending on what the request is. Looking at things like the URL path or what type of request using API S.

Is it a get, is it put a put method? Is it a post method and so on? So it's utilizing a rest API over HDTPS. So it's a secure connection over the internet.

And the mobile application can be coded now to speak to the API end point and the API N point can then proxy that those connection requests through on the actual information in the request through to the various different micro services. So how is it structured? So in API gateway, we have a graphical interface which is nice and useful to create our configuration and it looks something like this here, we have something called a resource. OK.

I've highlighted in the orange boxes, what the resources are essentially, these are a path in the API. So if you imagine that the API N point is a URL, so it's a publicly accessible URL, then we can configure paths that we add on to that URL. So slash booking for the booking service slash inventory for the inventory service slash payment for the payment service within each of those resources, we then create the methods. So you can see those here like get and put and post and delete.

These are http methods. So now when we want to retrieve booking information, we're going to or the application is going to issue a get request to the booking resource. And of course, we can then integrate each of these methods to our back end micro services databases and so on and it supports a variety of different end points. We've got http end points here.

We've got LAMBDA, we've got ECs, we've got Dynamo DB and of course, it does support more than this. Let's have a look at another example to put this together here. We have an estuary website. Let's imagine.

This is a static website. We then have two different Lambda functions. One for sending support emails, one for logging, support tickets, and then we have an API gateway end point in front. So here we've created the resources.

One is slash send email, one is slash submit ticket. And in both cases, there is a post method we can see now that when the customer submits a support request, the information could get emailed through to the support team or they can submit a support ticket and that gets logged into a dynamo DB table by the Lambda function. So there's an example where we have a single endpoint, we then have the resources and the methods directing the request through to the different back end micro services.


### 87. [HOL] Serverless Application with REST API – Part 2

Welcome back in this lesson, which is part two of our building a surplus application with rest API. We're gonna complete what we started in part one. So in part one, we ended here, we used a the Lambda function console to submit a test event which went through our submit order function into the queue, which triggered our process order function, which placed the product into the table. So it looks like we have an order from our ecommerce store.

We also use the cli what we're gonna do now is we're going to add a static website running on S3 and then we're gonna add an Amazon API gateway rest API. This time from the internet using a browser, we can submit an order and the static website will forward the request to the rest API which then proxies the request through to the Lambda function. So again, proxy just means that the API is not performing any kind of transformation of the incoming information to the format that's required for the back end. In this case, the back end the Lambda function does is able to pick up the information in the format that comes straight through from the static website from the form and process that information.

So we just proxy it straight through. OK. Let's head back over and finish this lab back in the instructions file. I'm now down on line 68 here.

The part two. And what we're gonna do first is create the API, the API is gonna be called product orders API. So let's go ahead and create it and then we'll come back and look at some of the configuration. Let's go to the API gateway console here.

We're going to from the main screen here. Just scroll down until you see rest. API, not the private one. This is the public.

One. Click on build new API, provide a name by default. The endpoint type is regional. We don't want edge optimized or private.

So let's create the API. Now it puts us into the API configuration. What we need to do here is create resources and methods. The first thing we're gonna do is create a resource and that resource is going to be orders.

So the path is slash and then we have orders, slash orders and click on cause which is cross origin resource sharing. We're coming from another website, we're coming from a static website running on S3. That's where the request is gonna come from to the API. So we need to enable cross origin resource sharing to allow that to happen.

So what we can do then is simply create the resource So where we are now is we've done this step here. Step two, create the orders resource with cause enabled. Then we need to create a post method for slash orders that's integrated with the submit order function. Once we've done that, we need to enable cause again.

So we have to run some additional settings, select all the options and then deploy to a new stage. So when we deploy our, our API, we actually deploy it to a stage and it provides a name that's part of the URL. And we need the API end point that includes the stage name. You'll see that when we get there.

So firstly, let's come back what we need to do. We have the slash orders selected. So we're under resources slash orders. I need to click create method on the right hand side, we're going to choose post.

So these are all the various different http methods we're gonna choose post because we're posting a request that's uh essentially uploading some information. Lambda function is the integration. It is gonna be a proxy integration as I've explained before because we just send the information in the current form straight through to our submit order function. So make sure you choose the right function here.

That's all you need to do here. We can simply create the method. OK? So now the method has been created.

All we need to do is head back up to slash orders, click on enable cause and then select all of these different options and then save. So again, we're just making sure that we have the cause settings enabled because the request is coming from another website. Once we've done that we can deploy our API, we deploy the API to a stage, we're going to create a new stage and the stage is going to be called prod all lowercase and then click on deploy. Now we have an invoke URL.

OK? So note that the invoke URL, it has a specific and unique identifier for your API and on the end it has prod. OK? That was the stage that we deployed to all of that's inform important information.

So we wanna copy the invoke URL. Now back in the instructions here, it's telling us to update the invoke URL in the index file and the note here that it should it up, end up looking something like this where we have slash prod and then slash orders on the end as well. So make sure you do that. Let's go to line 32 of our code here, your API endpoint, paste it in, we've got the slash prod.

So then I just need to type slash orders. OK? So that remember that's the resource, the resource is part of the path, it's part of the URL path. So we have to add it on here for the request to work.

Once you've done that, don't forget to save your index dot html. And what we want to do now is come back and create our static website. I've already got a couple, but I'll do it from scratch. So let's call this my API static website dash and then just make it, make it unique.

I do want to enable public access for this one. Let's acknowledge that I'm gonna do that. Just create the bucket. We will choose our bucket, my API static website.

I'm going to go to properties all the way to the bottom static website hosting enable index document is index dot html. And then of course, we wanna scroll down and save changes. I've got the bucket policy code that you need here. So what we'd want to do is just copy this code to allow public read of the objects.

So back in our bucket, we can go to permissions under bucket policy, edit, paste the code in and we need to of course update our bucket A RN here, making sure the slash star is still in there and then save the changes. Now lastly, let's come back and we need to upload our file. So I've uploaded my index dot html there it is. I can close out of here.

I've got the file, let's go to properties and I can click on the static website endpoint. So now I can enter, enter a product name. Let's say it's gonna be an iphone and I want one of them and then let's submit and it says order submitted successfully. If I now come back to my Dynamo DB table, let's refresh to scan the table and there is my iphone.

So that is it working correctly? Now, I'll show you a couple of places where things can go wrong. Firstly, the index for HTML, I already mentioned it, but make sure you've updated your endpoints and that you've got slash prods slash orders in there on the end of your end point. So it should look very much like this one.

The other place things can go wrong is back in the API. So again, I keep mentioning cos it can be something that you have to sometimes come back in and just do it again. So if for any reason it's not working, come back and enable cos again, once you've done that, go and deploy the API again and when you deploy it for a second time, you can actually choose the stage. So deploy, wait a minute or two, sometimes the deployment of an API stage uh does take a minute or two to actually take effect.

So that can be an issue as well. And then lastly, it's useful to use developer tools in your browser. If you want to troubleshoot what's going on. For example, for this, I prefer to use the Google Chrome and with Google Chrome, you go to view developer tools and and then go to the network tab and then when we submit orders, we can see a bunch of information happening in the right hand side there.

So for example, if this time I put in cheese uh and quantity two and then submit, we will see things happening. In this case. Obviously, everything is good. If you have any issues, then it should show you some, some sort of red exits on the right hand side here and you can troubleshoot.

It might be a cause error, for example, or it might be a path not found or something like that. So the developer tools very useful. So that's it for this lab. Our configuration is fully working now with a static website and an API and then our server application running in the cloud.

So very easy obviously to delete all of these resources once you've finished, everything is within free tier, so shouldn't cost you anything anyway. Um But always a good idea to clean things up once you've finished.


### 88. Amazon EventBridge

Hey guys. In this lesson, I'm going to go through Amazon. Eventbridge. Eventbridge is a service event brus that allows us to build event driven applications.

Eventbridge supports various different event sources. There's lots of integration for Aws services out of the box. So it's very easy to integrate with various different Aws services. But you can also integrate custom applications and SAS applications as well.

So the event sort generate events, things that are happening to those services. For example, an EC2 an instance might be terminated, that would be an event, then the events get routed through the event bus into the rules engine where we can configure the rules that we require and those rules will direct the traffic to various different targets like lambda and kinesis and SQS and others. So Eventbridge helps us to ingest filter, transform and deliver events to build loosely coupled applications. Event sources can be as I mentioned before, various different sources such as Aws services themselves, wide variety of support there for many Aws services.

But then we can also utilize custom applications and SAS applications for our sources where the events are generated from. It supports a default event bus, which is there for AWS events. And then you can build custom event buses as well. For third party applications, the events get routed and filtered.

And so we have various different parameters that we can configure in the event rules in order to determine how we want our events to be routed and any customizations that we want to make for scalability and reliability. It automatically scales as a server service based on the number of events and it can handle millions of events per second. So very highly scalable and very reliable as well. Let's have a look at an example to help you understand how this works here.

We have two, we have an event that's been generated. In this case, it's a termination event. Now, this is an example of a very easy rule to create. There is actually a wizard that helps you to do this.

You can choose EC2 as the event source and you can literally specify the easy two instance terminated event. Then what we can do is apply those rules and route through to a target. In this case, it could be an S MS notification to let someone know that an instance has been terminated. Let's have a look at another example with eventbridge and Aws Cloud Trail.

Cloud trail is an auditing service. It logs all of the API actions in our account. So it keeps a record of who did what at what time and on what resource. So it generates events, those events can then be put through to the event bus.

So in this case, the S3 put bucket policy API was used, that means somebody has applied a bucket policy to an S3 bucket. Maybe we wanna know about that. So we create a rule in the event bus and it's gonna pick up these put bucket policy API actions and then it's gonna send them through to a target. In this case, lambda.

So what we might wanna do here is secure the estuary bucket. Maybe we don't want somebody putting on a custom bucket policy. So that of course, is the logic that we would then have in our Lambda function to secure the estuary bucket. Likewise, we could easily just use an S MS notification again and notify someone that this has happened or keep a log of it in a dynamo DB table, lots of power to do whatever we need to do.

In this case, the bucket has now been secured. So those are a couple of examples of working with eventbridge.


---

## Part 11: Machine Learning and AI


### 89. Introduction

Welcome to the section on machine learning and Artificial intelligence A I. So these concepts have been around for quite some time and the services and the tools and the technology has been growing over time and getting better and better. And really in the last couple of years, it's become extremely popular in the public realm. And people have started to understand what the benefits of A I really are.

Now, many of the machine learning services on AWS have been around for some years and the A I services are starting to really evolve. We have some new ones coming into play like Amazon Bedrock. Now, now, what I wanna focus on first in this section is more about helping you to understand how you can utilize A I to your advantage, both as a learner and as a productivity tool because I really believe that those who are going to have the job opportunities in the future are those who know how to use this technology the best. OK.

It's not gonna take your job away from you, but it's gonna make you better at your job. And if you don't keep up with the trends, other people are going to accelerate past you. So really understanding how to use things like chat GP T or Gemini or the various different generative A I models is a very important skill to have. And I think everybody should be using those skills in the workplace and as a learner and at home to help us to understand the technology, grow our skills and produce faster than we otherwise would.

So we'll start off looking at how you can utilize generative A I as a learner. I'll show you how to use chat TPT with some practical examples for generating code and project ideas as well to help you build your skills. Then what we're gonna do is have a look at some of the machine learning services on Aws and how we can use those in an automated pipeline. That's it for me.

I will see you in the next lesson.


### 90. Using Generative AI as a Learner

Hey guys in this lesson, I'm going to cover using generative A I as an educational assistant. So most of us have already started using GEN A I for a variety of different use cases. If you're not using it, you really need to be, it's extremely powerful and both as an educational assistant and also making us more productive as well. So I can answer a huge variety of questions, generate projects, ideas and even generate code and we're gonna see how to do that.

So I'm using chat GP T, you might be using a variety of other different gen A I models. That's fine. I prefer G A GP T at this point in it's a language model developed by open A I. So it, you submit text and it generates text and response and you can have really a conversation, it's conversation that's back and forth, you're asking questions, it's giving you answers and then you can ask additional questions and it remembers the context that's really important.

So you're having a contextual conversation. There's various different plans. I won't go into the details of these. It's up to you what you choose.

There is a free ver it gives you the older model and sometimes you can't get access to it. So that's a problem for 20 or $30 a month. I think it's so much so worth actually spending the money and getting access to the latest model and also being able to access it whenever you need to. Now the models are changing all the time.

You don't need to notify me that these numbers are out of date, maybe it's four plus, whatever the next one is, that's fine. Just use the latest model. If you can, now, you can install a variety of plugins as well for different functions and you can create browse and use your own GP TS. That means you can train the GP T for specific use cases.

Like maybe you wanna use it for code generation, maybe you wanna write articles, whatever it is you wanna do, that's only available for the plus and team plans at this point in time on chat GP T. So why would you wanna use a I as a learning tool? Well, you get immediate assistance with questions. Of course, when you're trying to learn cloud, you're probably gonna have a lot of questions.

You're gonna have some doubts, you're gonna have some confusion. Well, you've got this immediate assistance. It's like there's a person there with really broad knowledge, broad and deep knowledge who's able to then help you answer those questions in real time rather than rather than waiting for a response from somebody it's contextually aware. So you can have a conversation, you can then drill into areas where you're still a little bit confused or you just want more information and it's has extremely broad training data.

So almost any topic, it has um a very deep knowledge. Now there are some concerns so you need to check when the model was trained. Uh, facts could be out of date like AWS, for example, is changing at such a fast rate that sometimes it could be a little bit out of date by several months or more. And that can be, you know, quite a changes can happen on AWS during that time frame.

Sometimes the A I model is wrong. So you've got to make sure you check the work, you check what it's telling you. Does it make sense? Just fact check it.

Sometimes if you really need to, if it's important information, you need to sort of double check and just use your gut feel to, to understand whether it's giving you the right information or not. Sometimes it hallucinates that is a term used by A I experts. It means it kind of makes up the answer. I think sometimes it's trying to tell you what it thinks you want to hear.

So you gotta watch out for that now, for prompt engineering. So prompt engineering is we're putting in a prompt, we're asking it a question. We're trying to get it to give us some information we're trying to get it to generate some code. And so we have to get good at writing good prompts.

They should be clear but also specific about what you're asking for and what type of response you want to receive. Contextual information. Very useful. So give as much information as you can on the background of what it is you're trying to do and what the purpose of your query is.

And again, what type of response are you looking for from the A I model? In terms of instructional design, sometimes prompts are crafted to instruct the A I in a specific way of responding. So you can ask for a list, you can ask for bullet points, you can ask for a very brief summary, you can ask for detailed instructions, whatever it is that you need, use iterative refinement. That basically means you're doing it back and forth with the A I model, constantly reading the responses and then asking for a bit more information, providing a bit more context, a bit more input to get a better answer.

Now, code generation is one of the fantastic abilities of chat GP T and other A I models, we need to be specific and detailed about what we want. And for example, if you're trying to generate some projects for AWS, which is a, it's a really good tool for doing that. If you want some ideas for projects, it's gonna give you the ideas. It's also gonna generate the instructions and the code.

So be specific about what you want to achieve or ask it for some advice to come up with a scenario for you and then ask it to fill out the details and start building out the instructions and the code, define the scope. So make sure you're clear on what you want. Are you looking for a snippet of code? Are you looking for the full code?

Are you looking for building out functions, scripts and entire application architecture end to end it can do all of those things. So just need to be clear with the generative model as to what exactly you need, it can be useful to mention the programming languages and tools. So especially if you're learning a particular programming language like Python, for example, maybe you wanna ask the G the GP T to actually generate Python code for you that way it's gonna help you build your skills as well and you'll be able to start reading it and interpreting it and looking for any issues that might arise state Aws services. What exactly do you want to include in your architecture?

I'm assuming here that you're building some kind of project for aws, which means you could then specify that you want some kind of servius adventure of an application. And these are the services I want to include security and best practices. So if you have specific security or best practices. You need to adhere to make sure you're clear about that in your prompt, there can be issues with code, for example, where it's not written in the most secure fashion.

So you want to try and be careful about the code that's generated. I think in most organizations, they're not just gonna take code from something like chat GP T and put it into production. It should definitely go through uh some senior developers and some review processes to make sure that it's good code. You can also ask for error handling and logging.

So sometimes you'll ask it to generate some code for a Lambda function, but it won't include the logging capability in there, which means that if some issues arise, you can't go straight into cloud watch logs and find out what happened. So it's useful to just tell the GP T that you, you need some error handling logic built in and then test and validation. Always test and validate your code. Always check that it's written securely, always check of course that it's working and it's functional but it's secure as well.

So a few use cases that are really useful and these are things I want to go into in a hands on lesson. So firstly, just get GP T to answer some questions for you so you can use it as an educational system. Secondly, coming up with project ideas, the best way to build your skills on aws is to constantly work on projects, solve problems yourself and build things out th unique solutions to problems. You can work with the GP T to come up with the ideas.

You can also get the GP T to completely fill out the instructions and the code. It's still gonna be a learning exercise because I guarantee you it won't always work. First time. Sometimes I've asked for various different things like a, sometimes the lambda function code won't work correctly and you have to go and get the logging information from cloud watch logs, find the errors and provide them back to the GP T and say this is the error that occurred and then it's gonna start fixing the issues.

So there's still problems and you're still gonna learn as you build this out. But it's a really great tool in order to come up with the ideas. And then if we want to, we can try and build them out ourselves or we can get some assistance right through to detailed instructions.


### 91. [HOL] Creating Projects and Code with ChatGPT

Hey guys in this lesson, I'm gonna show you how you might want to use a A I service like chat GP T to create projects and code. So I'm logged into chat GP T I have a team plan which is about $30 a month. I think that's extremely cheap. It's probably worth 100 times that to me and my business.

But I think even for everyone just using this on a daily basis, even if it's just for relatively minor things, it's worth paying for. At least, I think it's about a 20 or $25 plan now that might change. Um That's the individual plan that gives you access to the premium features that might change by the time you watch this video and the models are changing over time. So as you can see in the top left here, it's telling me I have access to chat GP T four at this point in time.

That is the latest mod model. Now, if you get the free version, you get 3.5 I think four is significantly better than 3.5. So I definitely think it's worth paying to get access to the latest model. When you watch this video, this might not even be the latest model.

OK? So just use the latest model if you can because they do get a lot better over time. So all I need to do here is just put in some prompts and ask the uh A I to sort of help me in whatever way that I want it to. Now it's good to provide some context.

So I try to be fairly detailed now, in terms of trading projects, what I wanna do is I want it to help me come up with some projects ideas. Now, I don't really know exactly what I want at this point in time. I just know that I wanna learn some more about Aws and I don't really know how to come up with these ideas. So I want it to help me.

So what I'm gonna do is just ask it to provide some ideas and then I'm gonna choose one of the ideas. So let's set some context. Um I need you to act as a lab architect for Aws certification training. I need some ideas for learning Aws serverless services.

Yeah, that might be fun. Aws server services and I'm gonna give it some context. So uh or some, some more specificity if you like. So I want to say, I, I need a few ideas to choose from that are ideal for beginners to Aws.

If you're more advanced, just tell it that you want more advanced ones. And I'm gonna s specify exactly what I need. So, uh I want four ideas to choose from. So this is just a starting point.

I don't try and throw everything into one prompt. I just wanna get some ideas and let's see what it comes up with. Uh, and if I don't like the ideas, I'll ask it for more. OK?

We can just go back and forth all day. So yeah. OK. Let's see what it says.

Cus web application, build a simple web application with Lambda API gateway and Amazon is free. OK. That sounds pretty cool. What's the next one?

A data processing pipeline? OK. That's quite fun as well. S3 triggering a Lambda function for an event notification.

The Lambda function processes, the file process data gets stored in dynamo, DB. OK? That's pretty cool service notification system with some triggers again. We've got LAMBDA SNSS, MS.

Um We've got a service chat application that's pretty cool as well. So you can see straight away. I mean, there might be areas that are more interesting to you. Um I'm gonna say I like idea one provide.

So I'm gonna tell you exactly what I need. Now. I need you to provide detailed instructions. I need full code, not sample code.

Sometimes it tries to sort of summarize and say here's a little bit of code or, but you, you can fill out the rest. Well, I, that's not what I want. I want, I need full code, not sample code. I need detailed instructions for all steps in building the application.

Let's see what it comes up with. Sometimes it's super fast, sometimes a little bit slower but it gets there. Now one thing to note is oh, I'm gonna stop it straight away. This application will demonstrate the basics of the service application.

For the sake of this example. Let's build a basic helloworld example. I'm gonna say helloworld is boring. I need a more interesting solution that showcases Aws services better.

OK? So you can stop it whenever you need to. Let's design a service feedback form that collects user feedback, stores it. OK?

Now we're getting a bit more interesting. So we've got a static website, lambda functions triggered by api gateway database notification system. So now it's coming back with some information, don't know about you, but it doesn't look that detailed. So if that's the case, I mean, I I can certainly work off this but uh if you're a beginner that might not be detailed.

Now, here's the thing. Sometimes you can't get the end to end instructions in one go. What you might wanna do that at that point is break it down and say, OK, tell me uh explain to me in more detail. Step one.

OK? And then go on to step two and so on. Sometimes I've come up with some pretty complex projects, ideas and I break it down because I, I ask it to summarize the various different steps of the application. And then for each one of them, I build it out and I try to do some testing as I'm building it out as well.

One thing I can tell you is that this code might not work. I mean, look, it's pretty amazing that it's come up with this code for me. Is it gonna work? I don't know.

I'm gonna have to implement it often when we're using LAMBDA. We just need to make sure that we tell if it doesn't do it for us. Make sure we tell the A I to include logging so that we can get some information in cloudwatch logs and that's the place to go when your Lambda function doesn't execute correctly, go and have a look. You can often find an error message, literally just copy, paste that error message.

I don't even need to tell it. There's an error, I just copy, paste the error message into the chat and it finds, it understands what I'm talking about and it gives me some feedback, maybe it updates the code. So this is just the beginnings. Obviously, we could spend a lot of time on this.

It takes a bit of time to work with this. It's not gonna be a five minute job. If you want a working solution, it's gonna be a process. It might, you, you know, an hour might take you a few hours back and forth, you know, getting some more information.

The idea is that we, we're using this as a learning experience, not just uh getting some step by step instructions so that we can just build something because then we're just working to instruction. We wanna, we wanna actually learn what we're doing along the way so you can always stop and ask it to explain a little bit more detail about what it's doing. So certainly this is not an end to end solution. What I would do is I would go back and now ask it for a bit more information.

We probably want some more detail in things like API gateway to make sure that we can figure it correctly. We're gonna need to do some testing. We're almost definitely gonna have some issue that we're going to then need to have a back and forth with the A I to get it to help us to work towards a final solution. But that's an amazing way of building out ideas and learning and working with the A I to help us to advance our skills on Aws.

Now, there's a couple of other areas that I want to bring to your attention. So one is the cli, the cli is uh you know, it can be very useful, very powerful way of working with AWS, but it also can be quite frustrating trying to build out command lines. Chat G BT is brilliant at this. So let's say um I want to create uh VPC with public and private subnets.

I need you to provide the AWS cli commands to execute or to deploy this infrastructure simple as that. Now, this is somewhere where I found it very, very accurate. When we get into more complex code, cloud formation templates, it will write cloud formation templates for us. There's often problems uh we get sort of lambda function code and stuff like that.

Uh very good. But uh there's a few problems here and there. So you're constantly troubleshooting. I found with the cli it's, it's almost completely accurate every time.

So you can see it's, it's telling us all the various different commands that we need to, to perform and it should just tell us in the correct order as well. If it doesn't, I'll be surprised. It usually shows you the order. So create the VPC first, then you wanna create the public subnets, private subnets, internet gateway, attach the internet gateway to the VPC and so on.

So now we have all of the commands to perform this particular operation. As I mentioned, another thing you can get it to do is create cloud formation templates. Um Let's just say instead provide a cloud formation template to create this VPC. Now, I often specify um I, I want this to be in YAML, I want a YAML template.

It's a bit easier to read than JSON. Same with when I'm getting it to write function code for LAMBDA. Uh I'm more familiar with Python, so I usually tell it to write the code in Python. Otherwise it could be a variety of languages.

So um you can be very specific there. So again, cloud formation templates, sometimes they work perfectly, sometimes they don't. Um But once this is ready, I can simply copy the code, save it into a YAML file and then try and work with it in cloud formation. And if there are any problems in cloud formation, I'm gonna take the errors.

I'm gonna come back to chat GP T, I'm gonna put it in and hopefully it's gonna fix it for me. So there's just a few ways, there's unlimited ways that we can work with this technology. But I wanted to give you just a few ideas for the power and how we might utilize this as a learning tool.


### 92. AWS Machine Learning and AI Services

In this lesson. I'm going to cover some details about a few machine learning and A I services on Aws. Now there is a large category of machine learning and A I services. There's lots of them and it's a really fast growing area.

So there's quite a few that I'm not gonna cover. I just wanna give you a taster of what some of these services can do. So first let's get started with recognition, recognition can identify information in images. So here we've uploaded some images to recognition and it's going to do things like identify the objects.

I perform facial ana analysis as well. What what's happening here? This person's smiling, they're happy, their eyes are open and so on and we've got celeb celebrity recognition. So here it's actually found Dr Werner Vogels.

Now he's certainly a celebrity in the Aws world. So recognition could be added into an event driven architecture. Here, an image is uploaded to a bucket, a lambda function is then going to call recognition, which is gonna analyze the image and output some information to SNS which publishes it to lambda which might transform it in some way before adding it to a dynamo DB table. So that's just one example of an adventure of an architecture with recognition.

Now the remaining services that I'm gonna go through, you can basically build those into all sorts of different serverless and event driven applications as well. So here the lambda function process the results and creates the item in dynamo DB storing information about the image, whatever recognition identified. So recognition is for adding image and video analysis to your applications. It can identify objects, people, text scenes and activities and images and videos.

It processes videos stored in an estuary bucket. So we can then use an event notification to trigger the process and you can publish completion status to an SNS topic or you can just add it straight to dynamo DB. We then have transcribe where you can add speech to text capabilities to applications. Recorded speech can be converted to text before it can be used in applications.

And it uses a deep learning process called automatic speech recognition to then convert speech and text quickly and accurately. We then have translate. This is a neural machine translation service. It's simply translating languages.

So we might get transcribe to transcribe a video and then the results might be stored in JSON in a bucket. And then an event notification might call translate to translate from English into another language. Translate uses deep learning models to deliver more accurate and more natural sounding translations. And you can also use this for use cases such as localizing content for websites and applications comprehend is a natural language processing service.

So this is using machine learning to uh uncover information in unstructured data. So for example, pulling out sentiment and trying to work out, you know, what are the critical elements in some data. So in real time, you can automatically and accurately detect customer sentiment in your content. What are people saying about your products or your services?

We have Amazon Lex. This is a conversational A I for chat bots. So you can build conversational interfaces into any application using voice and text. You can build bots for use cases such as contact centers as well.

We have DEV ops Guri. This is a cloud operations service for improving application operational performance and availability. It can detect behaviors that deviate from normal operating patterns. So some benefits are detecting those operational issues in your DEV ops pipelines resolve issues with ML powered insights, elastically scale operational analytics and using ML to reduce alarm noise.

Lastly, here we have codeguru security. This can detect track and fix code security vulnerabilities anywhere in the development life cycle using ML and automated reasoning. It integrates with many ID ES and C I CD tools using a flexible API. It offers automatic bug tracking assisted remediation through suggested code fixes and performance optimization recommendations.

It can also detect anomalies and application profiles in real time as well. So those are just a few of the machine learning and A I services on Aws, there is a very broad portfolio and as I mentioned earlier, it's growing all the time.


### 93. [HOL] Process and Analyze Videos

Hey guys in this video, I'm gonna show you how to process and analyze images using the machine learning and A I tools on AWS. So what we're gonna do is a simplified version of what we saw a little bit earlier on. We're gonna have an S3 bucket. We're going to upload images to that bucket.

And when we do so there'll be an event notification that triggers a lambda function. The Lamba function is going to pass some information to recognition, to tell it to scan the image in the bucket. It's going to analyze that image and then the results are going to be stored in a dynamo DB table where we can review them. So the lambda function will receive the results and then create an item in dynamo DB in the course.

Download, you will find an AWS ML and A I directory. And in there you'll find this markdown file process, analyze images. So what we need to do is first simply create an S3 bucket, then we're gonna create a Dynamo DB table called image analysis results with a primary key of image name. So I'll just copy this.

Let's head over do these things in order. So we create the S3 bucket, then we're gonna create a Dynamo DB table. After that, we will create a Lambda function as well. So let's go to S3.

I'm going to create a bucket. The name for this doesn't really matter Mime recognition lab. And I'm just gonna make that unique and no other settings need to be applied here. So all defaults just create the bucket.

Next we want to go to Dynamo DB. We're gonna create our table. The table name from the document is gonna be image analysis results. And then for the partition key again, I wanna copy paste to make sure I get everything right, including the capitalization.

So we're gonna come back, put this in and then just scroll down and create the table with all the default settings. So that's the table being created while that's happening. We are going to create a Lambda function. It's gonna be called recognition lab.

It's gonna have a run time of Python 3.9. And then we're gonna add some code in. We can see the table's ready. Let's go over to lambda.

Create our function, provide the function name for runtime. I'm gonna select Python 3.9 and then we're gonna create the function. Couple of things we need to do for the function is we need to add this code for the code. We do need to update our table name here.

So I'm simply gonna copy it now. So let's go up to the table name here on line six image analysis results. And I can paste that into the code and then simply copy all the code. Once we have the code in place, we also need to add some permissions to the lambda functions, execution role.

So back in the function here, let's delete the default code paste in our code ensuring that we have the dynamo DB table name updated and then click on deploy now that it's deployed. I'm gonna go to configuration permissions, click on the roll name to edit the execution role. There are three policies we need to add. So I'm gonna attach policies.

The first one is for recognition and it's gonna be Amazon recognition, full access. We also need Dynamo DB, we need to be able to write items to the table. So Dynamo DB, full access. And then for S3, the function only needs to be able to read the object so read only access is fine.

So with that, I should have three additional policies added in in addition to the lambda basic execution role, which I can leave there. So we've got almost everything done. It's very simple to set this up because AWS make things so simple for us. The last thing we need to do before we test this is just create a trigger for object creation events in the S3 bucket.

As you know, we can do that. A couple of ways we can do it from S3 or we can come back to our function. Click on add trigger and then search for the S3 service. Choose our bucket for event types.

I'll leave the default all object rate events acknowledge here and then click on add and that's gonna add a trigger to my Lambda function. So now I have a Lambda function I have here the table. I'm gonna go and explore items. There's nothing in there yet.

Of course. And what we're going to do is we're going to set up a test event. Now, one more thing I do need to come back to my Lambda function. Now, it does the way this lab works is the Lambda function submits the event to recognition.

It then needs to receive the information back because it's the same function that's writing the event into dynamo DB. Now, that's not necessarily the best solution. You could have a separate function for doing this and that might sort of decouple things a little bit. And that way you can reduce the execution time of your function for a lab like this, it doesn't matter too much, but it does mean that the function needs a little bit more time to complete.

So what we're going to do is under configuration, general configuration, I'm simply gonna at the general configuration here and change the time out to 30 seconds rather than three seconds and then save. So now let's go to the bucket and I'm gonna click on my recognition bucket. Click on upload and you just need some files. I've got these ones from previous lab that have fruit in them.

Let's add those in and then click on upload. I'll go and add something else. Let's have a look. I've got a, I've got a couple of files here.

This one is an image of a laptop. Let's see what it thinks of that one and then click on upload. So now you just need to wait a few seconds. It shouldn't take too long, but give it a minute maybe.

And we should see some results over here. The uh initial ones might be ready by now. In fact, all of them are, they go very quick. So now we get these free results for the three different JPEG images.

We can see some information here. It's got a confidence percentage. It's got uh what it thinks it is. So the pineapple food, same with the papaya with the laptop image.

It knows it's a computer. If I click on here, we get to see a bit more information. So it knows that it's electronics, it thinks it's a laptop. Um It's telling us that or that might be the name of the document.

So, oh, it's saying PC. So yeah, it has worked that out. Um It's seen a cup in the image, a table, some computer hardware and monitor. So and a pen and so on so we get a bit of information there.

So it's done that analysis and now it's uh provided the results and those have been, have been locked into a dynamo DB table.


---

## Part 12: Get Certified on AWS


### 94. Introduction

Hey guys and welcome to the end of the course. This is the last section and I hope you've really enjoyed the course. Built lots of knowledge and practical skills along the way and had some fun in the process. Now, in this section, all I'm gonna do is talk about AWS certifications.

So if you are interested in taking your skills to the next level and putting them into practice in the industry, or if you're already in the industry looking for that next step, career change, then certifications can make the difference. So I'll just talk about the different pathways and how you can get started learning aws from a certification standpoint and then being able to prove your skills to employers.


### 95. Get Certified on AWS

Hey guys, I hope you've enjoyed your learning journey so far on Aws. And if you're excited about Aws, one great thing you can do is to get Aws certified. So if you're gonna start your career in Aws or you're transitioning from your on premises and traditional it infrastructure skills into cloud skills, then certification can really help you. So why might you want to work in cloud?

Well, job demand is constantly growing. There's a lot of jobs out there today even in difficult economic circumstances. And I think it's only gonna get better with evolutions of A I and machine learning. We're seeing even more companies moving more workloads into the cloud and utilizing the cloud because of the very advanced technologies and services that are offered only really in cloud providers globally relevant skills as well.

So cloud computing is something you can take all over the world. And in many cases, you can work from home today as well. And there's lots of rewarding career paths, whether you want to go into solutions architecture, whether you want to be a site reliability engineer, whether you want to be a cloud engineer or a Devops engineer. Whatever you want to do, there is a rewarding career path ready for you and great salaries.

This is an industry that pays very, very well. So if you get the right skills and experience, you can really build a very high paying career. Now, why specifically cation? Well, it helps you to demonstrate skills to employers.

I would say that certifications are not necessarily a differentiator today because most people have them, but they are a prerequisite to getting jobs in the cloud. You need to make sure you're certified in order to get jobs today. So this will help you to demonstrate that you have certain skills, it will help you to differentiate yourself if you have enough cations and experience to match. Ok?

Make sure that you have the experience to match the key is to get lots of hands on practice. Even if, if you're not working in the cloud, you can with the cations and the experience start to really build up a good online profile and gain knowledge. So it's a way of actually learning as you get certified as well. It gives you a structured pathway towards actually building those skills and you get to develop practical skills.

So as long as you're with the right learning provider who's doing a lot of hands on training, make sure that you're always doing hands on because you really need to put it into practice in order to, to be successful in a career. Now I'll show you what the Aws certification landscape looks like today and it's changing all the time. We've actually just recently had an announcement of some, some retirements of certain exams and the addition of new ones. So we have the foundational level.

This is great for anyone who's just getting started in the cloud. Even if you're coming from an existing it skill set. I recommend starting here because it gives you a good foundational knowledge of the cloud and the benefits and use cases of the cloud. Then at the associate level, we have these four cations solutions architecture developer C IOPS administrator and data engineer.

These are all the associate ST investigations. These are a bit more difficult, quite a bit more difficult than the foundational level and they're designed for specific job roles. Now there's a lot of overlap between these ST applications, especially the free towards the left there, the solutions architect developer and cops, there's a lot of overlap between them. And that means that if you get one, it's fairly easy to get the next ones by just learning the differences between those different exam guides at the professional level, we then have the dev ops engineer professional and the solutions architect professional.

Now these are quite a bit more difficult, especially the solutions architect professional that is a very difficult certification to attain. I recommend that you get all the associates first and then do the solutions architect professional. Now, along the side, there's some specialty certifications. You don't need to tell me if these are changed.

They are, I expect they're going to be bringing in some new ones recently. They've just retired some exams. So I'm showing you the ones that at this point in time we know are going to be there in the future. So we've got the advanced networking specialty, the security specialty and the machine learning specialty.

And I think there'll be at least a couple more coming soon. The specialties are for where you have very specific and deep knowledge in a certain area like the advanced networking specialty. If you're coming from a networking background, I would not recommend going straight to a specialty certification. Even if you're a machine learning expert, a security expert or a networking expert, get at least one of the associates first.

Probably the solutions architect of social is the best of the associate certifications for most people because it has such a broad set of Aws services that are covered within the scope of that exam. So I would start there then move on to the specialties if that's your background and expertise. So here is a link where you can actually go to the Aws website and have a look at what the latest is on the certification landscape there. So now is a great time to take action.

You've just worked through this course and you've learned a lot. Keep it going. Now we have some great on demand training courses on our platform for Aws. For many of the Aws certifications, we go into a lot of depth and we make sure that we always teach with a very practical and hands on teaching style.

We also have hands on challenge labs which are sandbox based environments where you get to set some challenges and you have to complete those challenges and then we have live boot camps. So these are for those who really want to take their skills to the next level, build out projects, work in environments with a cohort of other learners where you can all work together, taught by experts who have decades of experience and build out some more advanced projects and capstones and things that you can demonstrate to employers. That's really the sort of premier offering there for those who want that level of experience and who want to really build a successful career in the cloud. So that's it for this lesson.

I wish you all the best. Thanks for taking this course and I hope to see you in the future.
