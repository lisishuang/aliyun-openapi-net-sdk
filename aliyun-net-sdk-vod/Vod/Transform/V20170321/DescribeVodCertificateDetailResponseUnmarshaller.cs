/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodCertificateDetailResponseUnmarshaller
    {
        public static DescribeVodCertificateDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodCertificateDetailResponse describeVodCertificateDetailResponse = new DescribeVodCertificateDetailResponse();

			describeVodCertificateDetailResponse.HttpResponse = context.HttpResponse;
			describeVodCertificateDetailResponse.RequestId = context.StringValue("DescribeVodCertificateDetail.RequestId");
			describeVodCertificateDetailResponse.Cert = context.StringValue("DescribeVodCertificateDetail.Cert");
			describeVodCertificateDetailResponse.Key = context.StringValue("DescribeVodCertificateDetail.Key");
			describeVodCertificateDetailResponse.CertId = context.LongValue("DescribeVodCertificateDetail.CertId");
			describeVodCertificateDetailResponse.CertName = context.StringValue("DescribeVodCertificateDetail.CertName");
        
			return describeVodCertificateDetailResponse;
        }
    }
}